using Microsoft.AspNetCore.Http;
using MyProject.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WebApi.Services
{
    public class CartSessionService : ICartSessionService
    {
        IHttpContextAccessor _httpContextAccessor;

        public CartSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Session'da cart key'i ile sepeti çeker. Eğer yok ise boş bir sepet set eder.
        /// </summary>
        public Cart GetCart()
        {
            string objectString = _httpContextAccessor.HttpContext.Session.GetString("cart");

            //Eğer Session içinde sepet yok ise boş yeni bir sepet oluşturur ve döner.
            if (objectString == null)
            {
                var cartJson = JsonConvert.SerializeObject(new Cart());
                _httpContextAccessor.HttpContext.Session.SetString("cart", cartJson);
                objectString = cartJson;
            }

            return JsonConvert.DeserializeObject<Cart>(objectString);
        }

        /// <summary>
        /// Sepeti Session'a Json formatında "cart" key'i ile set eder.
        /// </summary>
        public void SetCart(Cart cart)
        {
            var cartJson = JsonConvert.SerializeObject(cart);
            _httpContextAccessor.HttpContext.Session.SetString("cart", cartJson);
        }
    }
}
