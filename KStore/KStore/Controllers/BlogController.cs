using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KStore.Models.ProductViewModels;
using KStore.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Rendering;
using KStore.Application.ViewModels.Product;
using KStore.Models;

namespace KStore.Controllers
{
    public class BlogController : Controller
    {
        private IBlogService _blogService;
        IConfiguration _configuration;
        public BlogController(IBlogService blogService, IConfiguration configuration)
        {
            _blogService = blogService;
            _configuration = configuration;
        }

        public IActionResult Index(string keyword, int? pageSize, string sortBy, int page = 1)
        {
            var blogDisp = new BlogDispViewModel();
            if (pageSize == null)
                pageSize = _configuration.GetValue<int>("PageSize");

            blogDisp.PageSize = pageSize;
            blogDisp.SortType = sortBy;
            blogDisp.Data = _blogService.GetAllPaging(keyword, pageSize.Value, page);

            return View(blogDisp);
        }

        [Route("{alias}-b.{id}.html", Name = "BlogDetail")]
        public IActionResult Detail(int id)
        {
            return View(_blogService.GetById(id));
        }
    }
}
