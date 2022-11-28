using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using KStore.Application.ViewModels.Product;

namespace KStore.Models
{
    public class ShoppingCartViewModel
    {
        public ProductViewModel Product { set; get; }

        public int Quantity { set; get; }

        public decimal Price { set; get; }

        public ColorViewModel Color { get; set; }

        public SizeViewModel Size { get; set; }

        public StatusProduct Status { get; set; } = StatusProduct.Success;

        public enum StatusProduct
        {
            [Description("")]
            Success,
            [Description("This product is out of stock")]
            OutStock,
            [Description("Please choose size and color")]
            NotSize
        }
    }
}
