using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assign5bookstore_413.Models;

namespace assign5bookstore_413.Components
{
    /// <summary>
    /// This is the program logic for how to return selected data. 
    /// Currently this filters only by category. 
    /// Associated tabhelper is <vc:navigation-menu>
    /// </summary>
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookRepository repository;

        public NavigationMenuViewComponent(IBookRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
