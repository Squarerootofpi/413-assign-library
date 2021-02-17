using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assign5bookstore_413.Models
{
    /// <summary>
    /// Eventually, when we are taught how, will put this in its own DB.
    /// </summary>
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
    }
}
