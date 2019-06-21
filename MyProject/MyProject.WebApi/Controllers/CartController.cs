using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProject.Business.Abstract;
using MyProject.WebApi.Models;
using MyProject.WebApi.Services;

namespace MyProject.WebApi.Controllers
{
    public class CartController : BaseController
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;
        public CartController(
            ICartSessionService cartSessionService,
            ICartService cartService,
            IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public ActionResult AddToCart(int productId, int count)
        {
            var productToBeAdded = _productService.GetById(productId);

            var cart = _cartSessionService.GetCart();

            var cartLineProduct = cart.CartLines.FirstOrDefault(c => c.Product.Id == productId);


            //Stok kontrolü
            if ((cartLineProduct != null && (cartLineProduct.Quantity + count) > productToBeAdded.Stock) ||
                (cartLineProduct == null && count > productToBeAdded.Stock))
            {
                this.SetAlert(string.Format("Ürün: {0},stok adeti yetersiz.", productToBeAdded.ProductName),true);

                return RedirectToAction("Index", "Home");
            }

            _cartService.AddToCart(cart, productToBeAdded, count);

            _cartSessionService.SetCart(cart);

            this.SetAlert(string.Format("Ürün: {0}, başarıyla sepete eklendi.", productToBeAdded.ProductName));

            return RedirectToAction("Index", "Home");
        }

        public ActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartSummaryViewModel viewModel = new CartSummaryViewModel
            {
                Cart = cart
            };

            return View(viewModel);
        }

        public ActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCart(cart);
            this.SetAlert("Ürün sepetten çıkarıldı.");

            return RedirectToAction("Index", "Home");
        }
    }
}