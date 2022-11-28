using System.Collections.Generic;
using KStore.Application.ViewModels.Blog;
using KStore.Application.ViewModels.Common;
using KStore.Application.ViewModels.Product;

namespace KStore.Models
{
    public class HomeViewModel
    {
        public List<BlogViewModel> LastestBlogs { get; set; }
        public List<SlideViewModel> HomeSlides { get; set; }
        public List<ProductViewModel> HotProducts { get; set; }
        public List<ProductViewModel> TopSellProducts { get; set; }

        public List<ProductViewModel> NewProducts { get; set; }

        public List<ProductViewModel> TopRateProduct { get; set; }

        public List<ProductCategoryViewModel> HomeCategories { set; get; }

        public string Title { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
}
