using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u24758354_Practical.Models
{
    public class Article : Publication
    {
        public string ArticleID { get; set; }
        public string Date()
        {
            return PublicationDate.ToString("dddd, dd MMMM yyyy");
        }
        public Article(Author authorName, string title, string type, string summary, string link, DateTime date, string image) 
             : base(authorName, title, type, summary, link, date, image)
        { }
    }
}