using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using KStore.Models;
using KStore.Models.AccountViewModels;
using KStore.Services;
using KStore.Data.Entities;
using KStore.Data.Enums;
using PaulMiami.AspNetCore.Mvc.Recaptcha;
using KStore.Extensions;
using KStore.Application.Interfaces;
using KStore.Application.ViewModels.Product;
using KStore.Utilities.Dtos;
using KStore.Utilities.Constants;

namespace KStore.Controllers
{
    public class UserInfoController : Controller
    {
        IProductService _productService;
        private readonly UserManager<AppUser> _userManager;
        private IBillService _billService;

        public UserInfoController(
             UserManager<AppUser> userManager,
             IProductService productService,
             IBillService billService)
        {
            _userManager = userManager;
            _billService = billService;
            _productService = productService;
        }

        public IActionResult Wish()
        {
            List<ShoppingCartViewModel> data = new List<ShoppingCartViewModel>();
            var session = HttpContext.Session.Get<List<ShoppingCartViewModel>>(CommonConstants.WishSession);
            if (session != null)
            {
                data = session;
            }
            return View(data);
        }

        public IActionResult OrderTracking()
        {
            var CustomerId = Guid.Parse(User.GetSpecificClaim("UserId"));
            var data = _billService.GetAllBindByUserID(CustomerId);
            return View(data);
        }

        [HttpPost]
        public IActionResult AddToWish(int productId)
        {
            //Get product detail
            var product = _productService.GetById(productId);

            //Get session with item list from cart
            var session = HttpContext.Session.Get<List<ShoppingCartViewModel>>(CommonConstants.WishSession);
            if (session != null)
            {
                //Convert string to list object
                bool hasChanged = false;

                //Check exist with item product id
                if (session.Any(x => x.Product.Id == productId))
                {
                    foreach (var item in session)
                    {
                        //Update quantity for product if match product id
                        if (item.Product.Id == productId)
                        {
                            hasChanged = true;
                        }
                    }
                }
                else
                {
                    session.Add(new ShoppingCartViewModel()
                    {
                        Product = product,
                        Price = product.PromotionPrice ?? product.Price
                    });
                    hasChanged = true;
                }

                //Update back to cart
                if (hasChanged)
                {
                    HttpContext.Session.Set(CommonConstants.WishSession, session);
                }
            }
            else
            {
                //Add new cart
                var cart = new List<ShoppingCartViewModel>();
                cart.Add(new ShoppingCartViewModel()
                {
                    Product = product,
                    Price = product.PromotionPrice ?? product.Price
                });
                HttpContext.Session.Set(CommonConstants.WishSession, cart);
            }
            return new OkObjectResult(productId);
        }

        public IActionResult RemoveFromWish(int productId)
        {
            var session = HttpContext.Session.Get<List<ShoppingCartViewModel>>(CommonConstants.WishSession);
            if (session != null)
            {
                bool hasChanged = false;
                foreach (var item in session)
                {
                    if (item.Product.Id == productId)
                    {
                        session.Remove(item);
                        hasChanged = true;
                        break;
                    }
                }
                if (hasChanged)
                {
                    HttpContext.Session.Set(CommonConstants.WishSession, session);
                }
                return new OkObjectResult(productId);
            }
            return new EmptyResult();
        }
    }
}
