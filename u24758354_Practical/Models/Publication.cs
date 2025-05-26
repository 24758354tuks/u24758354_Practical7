using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u24758354_Practical.Models
{
    public class Publication
    {
        public Author Author { get; set; } 
        public string Title { get; set; }
        public string Type { get; set; }
        public string Summary { get; set; }
        public string Link { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Image { get; set; }

        public Publication(Author authorName, string title, string type, string summary, string link, DateTime date, string image )
        {
            Author = authorName;
            Title = title;
            Type = type;
            Summary = summary;
            Link = link;
            PublicationDate = date;
            Image = image;
        }
    }
}