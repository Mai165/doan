using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KStore.Application.Interfaces;
using KStore.Models;

namespace KStore.Controllers.Components
{
    public class MainMenuViewComponent : ViewComponent
    {

        private IProductCategoryService _productCategoryService;

        private IProductService _productService;

        private IPageService _pageService;

        public MainMenuViewComponent(IProductCategoryService productCategoryService,IProductService productService,IPageService pageService)
        {
            _productCategoryService = productCategoryService;
            _productService = productService;
            _pageService = pageService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            MainMenuViewModel model = new MainMenuViewModel();
            model.ProductCategoryViewModels = _productCategoryService.GetAll();
            model.BestSells = _productService.GetBestSell(3);
            model.AboutPage = _pageService.GetSigleActive()?.Alias;
            return View(model);
        }
    }
}
