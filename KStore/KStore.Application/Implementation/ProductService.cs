using AutoMapper;
using AutoMapper.QueryableExtensions;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using KStore.Application.Interfaces;
using KStore.Application.ViewModels.Common;
using KStore.Application.ViewModels.Product;
using KStore.Data.Entities;
using KStore.Data.Enums;
using KStore.Infrastructure.Interfaces;
using KStore.Utilities.Constants;
using KStore.Utilities.Dtos;
using KStore.Utilities.Helpers;
using System.Globalization;

namespace KStore.Application.Implementation
{
    public class ProductService : IProductService
    {
        private IRepository<Product, int> _productRepository;
        private IRepository<Wish, int> _wishRepository;
        private IRepository<Tag, string> _tagRepository;
        private IRepository<ProductTag, int> _productTagRepository;
        private IRepository<ProductQuantity, int> _productQuantityRepository;
        private IRepository<ProductImage, int> _productImageRepository;
        private IRepository<WholePrice, int> _wholePriceRepository;
        private IRepository<BillDetail, int> _billDetailRepository;
        private IRepository<Bill, int> _billRepository;
        private readonly IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public ProductService(IRepository<Product, int> productRepository,
            IRepository<Tag, string> tagRepository, IRepository<Wish, int> wishRepository,
            IRepository<ProductQuantity, int> productQuantityRepository,
            IRepository<ProductImage, int> productImageRepository,
            IRepository<WholePrice, int> wholePriceRepository, IRepository<BillDetail, int> billDetailRepository, IRepository<Bill, int> billRepository,
        IUnitOfWork unitOfWork,
        IRepository<ProductTag, int> productTagRepository, IMapper mapper)
        {
            _wishRepository = wishRepository;
            _productRepository = productRepository;
            _tagRepository = tagRepository;
            _productQuantityRepository = productQuantityRepository;
            _productTagRepository = productTagRepository;
            _wholePriceRepository = wholePriceRepository;
            _productImageRepository = productImageRepository;
            _billDetailRepository = billDetailRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            this._billRepository = billRepository;
        }

        public ProductViewModel Add(ProductViewModel productVm)
        {
            List<ProductTag> productTags = new List<ProductTag>();
            if (!string.IsNullOrEmpty(productVm.Tags))
            {
                string[] tags = productVm.Tags.Split(',');
                foreach (string t in tags)
                {
                    var tagId = TextHelper.ToUnsignString(t);
                    if (!_tagRepository.FindAll(x => x.Id == tagId).Any())
                    {
                        Tag tag = new Tag
                        {
                            Id = tagId,
                            Name = t,
                            Type = CommonConstants.ProductTag
                        };
                        _tagRepository.Add(tag);
                    }

                    ProductTag productTag = new ProductTag
                    {
                        TagId = tagId
                    };
                    productTags.Add(productTag);
                }
                var product = _mapper.Map<ProductViewModel, Product>(productVm);
                foreach (var productTag in productTags)
                {
                    product.ProductTags.Add(productTag);
                }
                _productRepository.Add(product);
            }
            return productVm;
        }

        public void AddQuantity(int productId, List<ProductQuantityViewModel> quantities)
        {
            _productQuantityRepository.RemoveMultiple(_productQuantityRepository.FindAll(x => x.ProductId == productId).ToList());

            List<ProductQuantityViewModel> listUpdate = new List<ProductQuantityViewModel>();

            foreach (var item in quantities)
            {
                var data = listUpdate.Find(x => x.ProductId == item.ProductId && x.ColorId == item.ColorId && x.SizeId == item.SizeId);
                if (data != null)
                {
                    data.Quantity += item.Quantity;
                }
                else
                {
                    listUpdate.Add(item);
                }
            }

            foreach (var quantity in listUpdate)
            {
                _productQuantityRepository.Add(new ProductQuantity()
                {
                    ProductId = productId,
                    ColorId = quantity.ColorId,
                    SizeId = quantity.SizeId,
                    Quantity = quantity.Quantity
                });
            }
        }

        public void Delete(int id)
        {
            _productRepository.Remove(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ProductViewModel> GetAll()
        {
            return _mapper.ProjectTo<ProductViewModel>(
                _productRepository.FindAll(x => x.ProductCategory))
                .ToList();
        }

        public PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize)
        {
            var query = _productRepository.FindAll(x => x.Status == Status.Active);
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Name.Contains(keyword));
            if (categoryId.HasValue)
                query = query.Where(x => x.CategoryId == categoryId.Value);

            int totalRow = query.Count();

            query = query.OrderByDescending(x => x.DateCreated)
                .Skip((page - 1) * pageSize).Take(pageSize);

            var data = _mapper.ProjectTo<ProductViewModel>(query).ToList();

            var paginationSet = new PagedResult<ProductViewModel>()
            {
                Results = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };
            return paginationSet;
        }

        public ProductViewModel GetById(int id)
        {
            return _mapper.Map<Product, ProductViewModel>(_productRepository.FindById(id));
        }

        public List<ProductQuantityViewModel> GetQuantities(int productId)
        {
            var bill = _billDetailRepository.FindAll(x => x.ProductId == productId).ToList();

            var data = _mapper.ProjectTo<ProductQuantityViewModel>(
                _productQuantityRepository.FindAll(x => x.ProductId == productId))
                .ToList();
            foreach (var item in data)
            {
                var sold = bill.FindAll(x => x.ColorId == item.ColorId && x.SizeId == item.SizeId);
                var totalSold = item.Quantity;
                if (sold != null && sold.Count > 0)
                {
                    totalSold = item.Quantity - sold.Sum(x => x.Quantity);
                }
                item.RunningTotal = totalSold;
            }
            return data;
        }

        public void ImportExcel(string filePath, int categoryId)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets[1];
                Product product;
                for (int i = workSheet.Dimension.Start.Row + 1; i <= workSheet.Dimension.End.Row; i++)
                {
                    product = new Product();
                    product.CategoryId = categoryId;

                    product.Name = workSheet.Cells[i, 1].Value.ToString();

                    product.Description = workSheet.Cells[i, 2].Value.ToString();

                    decimal.TryParse(workSheet.Cells[i, 3].Value.ToString(), out var originalPrice);
                    product.OriginalPrice = originalPrice;

                    decimal.TryParse(workSheet.Cells[i, 4].Value.ToString(), out var price);
                    product.Price = price;
                    decimal.TryParse(workSheet.Cells[i, 5].Value.ToString(), out var promotionPrice);

                    product.PromotionPrice = promotionPrice;
                    product.Content = workSheet.Cells[i, 6].Value.ToString();
                    product.SeoKeywords = workSheet.Cells[i, 7].Value.ToString();

                    product.SeoDescription = workSheet.Cells[i, 8].Value.ToString();
                    bool.TryParse(workSheet.Cells[i, 9].Value.ToString(), out var hotFlag);

                    product.HotFlag = hotFlag;
                    bool.TryParse(workSheet.Cells[i, 10].Value.ToString(), out var homeFlag);
                    product.HomeFlag = homeFlag;

                    product.Status = Status.Active;

                    _productRepository.Add(product);
                }
            }
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductViewModel productVm)
        {
            List<ProductTag> productTags = new List<ProductTag>();

            if (!string.IsNullOrEmpty(productVm.Tags))
            {
                string[] tags = productVm.Tags.Split(',');
                foreach (string t in tags)
                {
                    var tagId = TextHelper.ToUnsignString(t);
                    if (!_tagRepository.FindAll(x => x.Id == tagId).Any())
                    {
                        Tag tag = new Tag();
                        tag.Id = tagId;
                        tag.Name = t;
                        tag.Type = CommonConstants.ProductTag;
                        _tagRepository.Add(tag);
                    }
                    _productTagRepository.RemoveMultiple(_productTagRepository.FindAll(x => x.Id == productVm.Id).ToList());
                    ProductTag productTag = new ProductTag
                    {
                        TagId = tagId
                    };
                    productTags.Add(productTag);
                }
            }

            var product = _mapper.Map<ProductViewModel, Product>(productVm);
            foreach (var productTag in productTags)
            {
                product.ProductTags.Add(productTag);
            }
            _productRepository.Update(product);
        }

        public List<ProductImageViewModel> GetImages(int productId)
        {
            return _mapper.ProjectTo<ProductImageViewModel>(
                _productImageRepository.FindAll(x => x.ProductId == productId)
                ).ToList();
        }

        public void AddImages(int productId, string[] images)
        {
            _productImageRepository.RemoveMultiple(_productImageRepository.FindAll(x => x.ProductId == productId).ToList());
            foreach (var image in images)
            {
                _productImageRepository.Add(new ProductImage()
                {
                    Path = image,
                    ProductId = productId,
                    Caption = string.Empty
                });
            }
        }

        public void AddWholePrice(int productId, List<WholePriceViewModel> wholePrices)
        {
            _wholePriceRepository.RemoveMultiple(_wholePriceRepository.FindAll(x => x.ProductId == productId).ToList());
            foreach (var wholePrice in wholePrices)
            {
                _wholePriceRepository.Add(new WholePrice()
                {
                    ProductId = productId,
                    FromQuantity = wholePrice.FromQuantity,
                    ToQuantity = wholePrice.ToQuantity,
                    Price = wholePrice.Price
                });
            }
        }

        public List<WholePriceViewModel> GetWholePrices(int productId)
        {
            return _mapper.ProjectTo<WholePriceViewModel>(
                _wholePriceRepository.FindAll(x => x.ProductId == productId)
                ).ToList();
        }

        public List<ProductViewModel> GetLastest(int top)
        {
            return _mapper.ProjectTo<ProductViewModel>(
                _productRepository.FindAll(x => x.Status == Status.Active)
                .OrderByDescending(x => x.DateCreated)
                )
                .ToList();
        }

        public List<ProductViewModel> GetHotProduct(int top)
        {
            return _mapper.ProjectTo<ProductViewModel>(
                _productRepository.FindAll(x => x.Status == Status.Active && x.HotFlag == true)
                .OrderByDescending(x => x.DateCreated)
                .Take(top))

                .ToList();
        }

        public List<ProductViewModel> GetRelatedProducts(int id, int top)
        {
            var product = _productRepository.FindById(id);
            return _mapper.ProjectTo<ProductViewModel>(
                _productRepository.FindAll(x => x.Status == Status.Active
                && x.Id != id && x.CategoryId == product.CategoryId)
            .OrderByDescending(x => x.DateCreated)
            .Take(top))
            .ToList();
        }

        public List<ProductViewModel> GetUpsellProducts(int top)
        {
            return _mapper.ProjectTo<ProductViewModel>(
                _productRepository.FindAll(x => x.PromotionPrice != null)
               .OrderByDescending(x => x.DateModified)
               .Take(top)).ToList();
        }

        public List<TagViewModel> GetProductTags(int productId)
        {
            var tags = _tagRepository.FindAll();
            var productTags = _productTagRepository.FindAll();

            var query = from t in tags
                        join pt in productTags
                        on t.Id equals pt.TagId
                        where pt.ProductId == productId
                        select new TagViewModel()
                        {
                            Id = t.Id,
                            Name = t.Name
                        };
            return query.ToList();
        }

        public bool CheckAvailability(int productId, int size, int color)
        {
            var quantity = _productQuantityRepository.FindSingle(x => x.ColorId == color && x.SizeId == size && x.ProductId == productId);
            if (quantity == null)
                return false;
            return quantity.Quantity > 0;
        }

        public List<Wish> GetWishByUserID(Guid UserID)
        {
            var data = _wishRepository.FindAll(x => x.CustomerId == UserID).ToList();
            foreach (var item in data)
            {
                item.Product = _productRepository.FindById(item.ProductId);
            }
            return data;
        }

        public List<ProductViewModel> GetBestSell(int top)
        {
            var data = _billDetailRepository.FindAll().OrderBy(x => x.Quantity).Take(top).ToList().Select(x => x.Id);

            return _mapper.ProjectTo<ProductViewModel>(
                _productRepository.FindAll(x => data.Contains(x.Id))
                .Take(top))
                .ToList();
        }

        public List<ProductViewModel> GetTopRateProduct(int top)
        {
            var data = _mapper.ProjectTo<ProductViewModel>(
                    _productRepository.FindAll().OrderByDescending(x => x.ViewCount));
            if (top != 0)
            {
                return data.Take(top).ToList();
            }
            return data.ToList();
        }

        public List<ProductViewModel> GetNewProduct(int top)
        {
            var data = _mapper.ProjectTo<ProductViewModel>(
                    _productRepository.FindAll().OrderBy(x => x.DateCreated)
                ).Take(top).ToList();
            return data;
        }

        public void UpdateViewCount(int productID)
        {
            var data = _productRepository.FindById(productID);
            if (data.ViewCount == null) data.ViewCount = 0;
            data.ViewCount++;
            _productRepository.Update(data);
            Save();
        }

        public List<BillDetail> GetBestSell(DateTime? startDate, DateTime? endDate, int top)
        {
            var query = _billRepository.FindAll(x => x.BillStatus == BillStatus.Completed);
            if (startDate.HasValue)
            {
                query = query.Where(x => x.DateCreated >= startDate.Value);
            }
            if (endDate.HasValue)
            {
                query = query.Where(x => x.DateCreated <= endDate.Value);
            }
            var bill = query.ToList();

            List<int> productIDList = new List<int>();
            List<BillDetail> billDetails = new List<BillDetail>();

            foreach (var item in bill)
            {
                var billDetail = _billDetailRepository.FindAll(x=>x.BillId==item.Id);
                if (billDetail != null)
                {
                    billDetails.AddRange(billDetail);
                }
            }
            return billDetails;
        }
    }
}