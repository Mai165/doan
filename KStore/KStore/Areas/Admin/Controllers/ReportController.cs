using KStore.Application.Interfaces;
using KStore.Application.ViewModels.Product;
using KStore.Models.Report;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace KStore.Areas.Admin.Controllers
{
    public class ReportController : BaseController
    {
        private IProductService _productService;

        public ReportController(IProductService productService)
        {
            this._productService = productService;
        }
        public IActionResult Revenues()
        {
            return View();
        }

        public IActionResult VisitProduct()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetProductReport(string startDate, string endDate, int top)
        {
            DateTime? start = null;
            DateTime? end = null;
            if (!string.IsNullOrEmpty(startDate))
            {
                start = DateTime.ParseExact(startDate, "dd/MM/yyyy", CultureInfo.GetCultureInfo("vi-VN"));
            }
            if (!string.IsNullOrEmpty(endDate))
            {
                 end = DateTime.ParseExact(endDate, "dd/MM/yyyy", CultureInfo.GetCultureInfo("vi-VN"));
            }
            var bestSell = _productService.GetBestSell(start, end, top);
            var topProduct = bestSell.GroupBy(x => x.ProductId).Select(g => new ReportViewModel()
            {
                ProductID = g.Key,
                TotalPrice = g.Sum(x => x.Quantity * x.Price),
                TotalQuantity=g.Sum(x=>x.Quantity)
            }).ToList();
            foreach(var item in topProduct)
            {
                item.ProductViewModel = _productService.GetById(item.ProductID);
            }
            ProductReportRes res = new ProductReportRes()
            {
                ResultALl = topProduct.OrderByDescending(x => x.TotalPrice).ToList(),
                Result = topProduct.OrderByDescending(x => x.TotalPrice).Take(top).ToList(),
                TotalRevenue = bestSell.Sum(x => x.Quantity * x.Price)
            };
            return new OkObjectResult(res);
        }

        [HttpGet]
        public IActionResult GetVisitProductReport(int top)
        {
            var data = _productService.GetTopRateProduct(0);
            VisitProductViewModel model = new VisitProductViewModel()
            {
                Result = data.Take(top).ToList(),
                ResultALl = data.Take(20).ToList()
            };
            return new OkObjectResult(model);
        }

        public class VisitProductViewModel
        {
            public List<ProductViewModel> Result { get; set; }

            public List<ProductViewModel> ResultALl { get; set; }
        }

        public class ProductReportRes
        {
            public List<ReportViewModel> Result { get; set; }

            public List<ReportViewModel> ResultALl { get; set; }

            public decimal TotalRevenue { get; set; }
        }
    }
}
