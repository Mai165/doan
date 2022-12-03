using System;
using System.Collections.Generic;
using System.Text;
using KStore.Application.ViewModels.Common;
using KStore.Application.ViewModels.Product;
using KStore.Data.Entities;
using KStore.Utilities.Dtos;

namespace KStore.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();

        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);

        ProductViewModel Add(ProductViewModel product);

        void Update(ProductViewModel product);

        void UpdateViewCount(int productID);

        void Delete(int id);

        ProductViewModel GetById(int id);

        void ImportExcel(string filePath, int categoryId);


        void Save();

        void AddQuantity(int productId, List<ProductQuantityViewModel> quantities);

        List<ProductQuantityViewModel> GetQuantities(int productId);

        void AddImages(int productId, string[] images);

        List<ProductImageViewModel> GetImages(int productId);

        void AddWholePrice(int productId, List<WholePriceViewModel> wholePrices);

        List<WholePriceViewModel> GetWholePrices(int productId);

        List<ProductViewModel> GetLastest(int top);

        List<ProductViewModel> GetHotProduct(int top);

        List<ProductViewModel> GetTopRateProduct(int top);

        List<ProductViewModel> GetNewProduct(int top);

        List<ProductViewModel> GetBestSell(int top);

        List<ProductViewModel> GetRelatedProducts(int id, int top);

        List<ProductViewModel> GetUpsellProducts(int top);

        List<TagViewModel> GetProductTags(int productId);

        bool CheckAvailability(int productId, int size, int color);

        List<Wish> GetWishByUserID(Guid UserID);

        List<BillDetail> GetBestSell(DateTime? startDate, DateTime? endDate, int top);
    }
}
