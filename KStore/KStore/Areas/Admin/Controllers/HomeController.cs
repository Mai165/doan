using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KStore.Extensions;
using KStore.Application.Dapper.Interfaces;
using KStore.Application.Interfaces;
using KStore.Application.Dapper.ViewModels;
using System.Globalization;
using KStore.Data.Entities;
using KStore.Application.ViewModels.Product;

namespace KStore.Areas.Admin.Controllers
{
 
    public class HomeController : BaseController
    {
        private readonly IReportService _reportService;

        private readonly IBillService _billService;

        private IProductService _productService;

        public HomeController(IReportService reportService, IBillService billService,IProductService productService)
        {
            _reportService = reportService;
            _billService = billService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            var email = User.GetSpecificClaim("Email");

            return View();
        }

        public async Task<IActionResult> GetRevenue(string fromDate, string toDate)
        {
            DateTime? start = null;
            DateTime? end = null;
            if (!string.IsNullOrEmpty(fromDate))
            {
                start = DateTime.ParseExact(fromDate, "MM/dd/yyyy", CultureInfo.GetCultureInfo("vi-VN"));
            }
            if (!string.IsNullOrEmpty(toDate))
            {
                end = DateTime.ParseExact(toDate, "MM/dd/yyyy", CultureInfo.GetCultureInfo("vi-VN"));
            }
            var bestSell = _productService.GetBestSell(start, end, 0);
            var billCount = _billService.GetAllByCreateDate(start, end);
            List<BillDetail> bestSellOld = new List<BillDetail>();
            List<BillViewModel> billCountOld = new List<BillViewModel>();
            if (start.HasValue && end.HasValue)
            {
                var time = end.Value - start.Value;
                bestSellOld= _productService.GetBestSell(start.Value.AddDays(-time.TotalDays), end.Value.AddDays(-time.TotalDays), 0);
                billCountOld = _billService.GetAllByCreateDate(start.Value.AddDays(-time.TotalDays), end.Value.AddDays(-time.TotalDays));
            }

            HomeViewModel model = new HomeViewModel();
            model.Sales = new Sale() { 
                TotalOld = bestSellOld.Sum(x => x.Quantity * x.Price),
                TotalCurrent = bestSell.Sum(x => x.Quantity * x.Price),
            };
            model.OrderCount = new Sale()
            {
                TotalCurrent = Convert.ToDecimal(billCount.Count),
                TotalOld = Convert.ToDecimal(billCountOld.Count)
            };
            model.RevenueReportViewModelList = await _reportService.GetReportAsync(fromDate, toDate);
            return new OkObjectResult(model);
        }

        public class HomeViewModel
        {
            public IEnumerable<RevenueReportViewModel> RevenueReportViewModelList { get; set; }
            public Sale Sales { get; set; }
            public Sale Turnover { get; set; }
            public Sale OrderCount { get; set; }
        }

        public class Sale
        {
            public decimal TotalOld { get; set; }

            public decimal TotalCurrent { get; set; }
        }
    }
}