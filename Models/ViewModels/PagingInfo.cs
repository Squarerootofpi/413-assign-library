using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assign5bookstore_413.Models.ViewModels
{
    /// <summary>
    /// Class to store all of the information/calculations about the pagination and status of data through pagination.
    /// </summary>
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int) Math.Ceiling(((decimal) TotalNumItems / ItemsPerPage));
    }
}
