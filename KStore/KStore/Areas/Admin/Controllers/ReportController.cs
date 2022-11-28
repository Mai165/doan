using KStore.Application.Interfaces;
using KStore.Models.Report;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
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

        [HttpGet]
        public IActionResult GetProductReport(string startDate, string endDate, int top)
        {
            var bestSell = _productService.GetBestSell(startDate, endDate, top);
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

        public class ProductReportRes
        {
            public List<ReportViewModel> Result { get; set; }

            public List<ReportViewModel> ResultALl { get; set; }

            public decimal TotalRevenue { get; set; }
        }
    }
}
