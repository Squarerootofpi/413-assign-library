﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assign5bookstore_413.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookDbContext _context;

        public EFBookRepository (BookDbContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => (_context.Books);
    }
}
