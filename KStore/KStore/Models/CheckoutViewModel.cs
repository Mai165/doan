using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KStore.Application.ViewModels.Common;
using KStore.Application.ViewModels.Product;
using KStore.Data.Enums;
using KStore.Utilities.Extensions;

namespace KStore.Models
{
    public class CheckoutViewModel : BillViewModel
    {
        public List<ShoppingCartViewModel> Carts { get; set; }
        public List<EnumModel> PaymentMethods
        {
            get
            {
                return ((PaymentMethod[])Enum.GetValues(typeof(PaymentMethod)))
                    .Select(c => new EnumModel
                    {
                        Value = (int)c,
                        Name = c.GetDescription()
                    }).ToList();
            }
        }
    }
}
