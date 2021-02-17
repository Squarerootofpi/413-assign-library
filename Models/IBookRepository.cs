using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assign5bookstore_413.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
