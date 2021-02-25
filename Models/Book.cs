using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assign5bookstore_413.Models
{
    /// <summary>
    /// Represents a book.
    /// </summary>
    public class Book
    {
        [Key]
        [Required]
        public int BookId { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Title { get; set; }

        /// <summary>
        /// Includes middle names/initials, just like FamilySearch does. So, in my opinion, this is as normalized as
        /// this needs to be, since even in FamilySearch they have a string that acts as the "given names" for all first names, 
        /// and then a list of alternate names.
        /// I technically could have done an array of strings for this (or made a bunch of not required variables like middle initial, 
        /// etc., but ideally, this will be implemented in the Author class once we finally learn how to connect tables together.
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        public string AuthorFirstNames { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string AuthorLastName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Publisher { get; set; }

        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"^([0-9]{3})[-]([0-9]{10})$", ErrorMessage = "Not a valid ISBN: should match ###-##########")]
        public string ISBN { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Classification { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Category { get; set; }

        [DataType(DataType.Currency)]
        [Required(AllowEmptyStrings =false)]
        public decimal Price { get; set; }

        [Required]
        public int TotalPages { get; set; }
    }
}
