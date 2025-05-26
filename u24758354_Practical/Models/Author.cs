using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u24758354_Practical.Models
{
    public class Author
    {
        public string AuthorName { get; set; }
        public Author(string authorName)
        {
            AuthorName = authorName;
        }
    }
}