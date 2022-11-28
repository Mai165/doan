using KStore.Application.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KStore.Models
{
    public class MainMenuViewModel
    {
        public List<ProductCategoryViewModel> ProductCategoryViewModels { get; set; } = new List<ProductCategoryViewModel>();

        public List<ProductViewModel> BestSells { get; set; } = new List<ProductViewModel>();

        public string AboutPage { get; set; } = string.Empty;
    }
}
