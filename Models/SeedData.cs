using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assign5bookstore_413.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title =             "Les Miserables",
                        AuthorFirstNames =  "Victor",
                        AuthorLastName =    "Hugo",
                        Publisher =         "Signet",
                        ISBN = "978-0451419439",
                        Classification =    "Fiction",
                        Category =          "Classic",
                        Price =  new decimal(9.95)
                    },
                    new Book
                    {
                        Title =             "Team of Rivals",
                        AuthorFirstNames =  "Doris Kearns",
                        AuthorLastName =    "Gooodwin",
                        Publisher =         "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification =    "Non-Fiction",
                        Category =          "Biography",
                        Price =  new decimal(14.58)
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirstNames =  "Alice",
                        AuthorLastName =    "Schroeder",
                        Publisher =         "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category =          "Biography",
                        Price =  new decimal(21.54)
                    },
                    new Book
                    {
                        Title =             "American Ulysses",
                        AuthorFirstNames =  "Ronald C.",
                        AuthorLastName =    "White",
                        Publisher =         "Random House",
                        ISBN = "978-0812981254",
                        Classification =    "Non-Fiction",
                        Category =          "Biography",
                        Price =  new decimal(11.61)
                    },
                    new Book
                    {
                        Title =             "Unbroken",
                        AuthorFirstNames =  "Laura",
                        AuthorLastName =    "Hillenbrand",
                        Publisher =         "Random House",
                        ISBN = "978-0812974492",
                        Classification =    "Non-Fiction",
                        Category =          "Historical",
                        Price =  new decimal(13.33)
                    },
                    new Book
                    {
                        Title =             "The Great Train Robbery",
                        AuthorFirstNames =  "Michael",
                        AuthorLastName =    "Crichton",
                        Publisher =         "Vintage",
                        ISBN = "978-0804171281",
                        Classification =    "Fiction",
                        Category =          "Historical Fiction",
                        Price =  new decimal(15.95)
                    },
                    new Book
                    {
                        Title =             "Deep Work",
                        AuthorFirstNames =  "Cal",
                        AuthorLastName =    "Newport",
                        Publisher =         "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification =    "Non-Fiction",
                        Category =          "Self-Help",
                        Price =  new decimal(14.99)
                    },
                    new Book
                    {
                        Title =             "It's Your Ship",
                        AuthorFirstNames =  "Michael",
                        AuthorLastName =    "Abrashoff",
                        Publisher =         "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification =    "Non-Fiction",
                        Category =          "Self-Help",
                        Price =  new decimal(21.66)
                    },
                    new Book
                    {
                        Title =             "The Virgin Way",
                        AuthorFirstNames =  "Richard",
                        AuthorLastName =    "Branson",
                        Publisher =         "Portfolio",
                        ISBN = "978-1591847984",
                        Classification =    "Non-Fiction",
                        Category =          "Business",
                        Price =  new decimal(29.16)
                    },
                    new Book
                    {
                        Title =             "Sycamore Row",
                        AuthorFirstNames =  "John",
                        AuthorLastName =    "Grisham",
                        Publisher =         "Bantam",
                        ISBN = "978-0553393613",
                        Classification =    "Fiction",
                        Category =          "Thrillers",
                        Price =  new decimal(15.03)
                    }
                    //new Book
                    //{
                    //    Title =             "",
                    //    AuthorFirstNames =  "",
                    //    AuthorLastName =    "",
                    //    Publisher =         "",
                    //    ISBN =              "",
                    //    Classification =    "",
                    //    Category =          "",
                    //    Price =  new decimal()
                    //}
                    );

                context.SaveChanges();
            }
        }
    }
}
