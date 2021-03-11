using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using assign5bookstore_413.Models;
using assign5bookstore_413.Infrastructure;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace assign5bookstore_413.Pages
{
    /// <summary>
    /// This is the model to add to carts. 
    /// </summary>
    public class AddToCartModel : PageModel
    {
        private IBookRepository _repository;

        public AddToCartModel (IBookRepository repo, Cart cartService)
        {
            _repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        /// <summary>
        /// If people come to the cart on a get without a bookId, then show the cart
        /// or make a new empty cart.
        /// </summary>
        /// <param name="returnUrl"></param>
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        /// <summary>
        /// When we post to this url, we want to add whatever item they added to their cart.
        /// If it's their first time, we need to make a new cart
        /// </summary>
        /// <param name="bookId"></param> the identification of the book they want to purchase
        /// <param name="returnUrl"></param> the url they came from that we should return back to
        /// <returns></returns>
        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = _repository.Books.
                FirstOrDefault(b => b.BookId == bookId);

            Cart.AddItem(book, 1);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Book.BookId == bookId).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
