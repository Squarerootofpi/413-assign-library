using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assign5bookstore_413.Infrastructure
{
    /// <summary>
    /// This class is a simple way to find out which page we came from before getting to the current page,
    /// So that we can tie it to a button/url etc....
    /// </summary>
    public static class UrlExtensions
    {
        public static string PathAndQuery(this HttpRequest request) =>
            request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.Path.ToString();
    }
}
