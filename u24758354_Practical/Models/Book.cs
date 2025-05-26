using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u24758354_Practical.Models
{
    public class Book : Publication
    {
        public int NoEditions { get; set; }
        public string Editions()
        {
            return $"{NoEditions} Edition(s)";
        }
        public string Date()
        {
            return PublicationDate.ToString("dddd, dd MMMM yyyy");
        }
        public Book(int noeditions, Author authorName, string title, string type, string summary, string link, DateTime date, string image) 
             : base(authorName, title, type, summary, link, date, image)
        {
            NoEditions = noeditions;
        }
    }
}