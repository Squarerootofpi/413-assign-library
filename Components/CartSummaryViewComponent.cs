using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using assign5bookstore_413.Models;
using System.Linq;
using System.Threading.Tasks;

namespace assign5bookstore_413.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
