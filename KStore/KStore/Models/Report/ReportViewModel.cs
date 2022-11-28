using KStore.Application.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KStore.Models.Report
{
    public class ReportViewModel
    {
        public ProductViewModel ProductViewModel { get; set; }
        public int ProductID { get; set; }
        public decimal TotalPrice { get; set; }

        public int TotalQuantity { get; set; }
    }

}
