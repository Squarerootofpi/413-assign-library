using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assign5bookstore_413.Models.ViewModels
{
    /// <summary>
    /// ViewModel that stores all the data for the Index.cshtml
    /// </summary>
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }

    }
}
