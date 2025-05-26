using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace u24758354_Practical.Models
{
    public class Repository
    {
        public static List<Publication> GetPublications()
        {
            var author1 = new Author("Koffi Umukoro");
            var author2 = new Author("Octavia Barret");
            var author3 = new Author("Gunnhild Aric");
            var author4 = new Author("Jakob Ayanda");
            var author5 = new Author("Shyam Benson");
            var author6 = new Author("Lucas Asim"); 

            return new List<Publication>
            {
                new Article(author1, "Improving the foundation of our falling sand simulator", "Article", "Addison is a detective from Sale who falls in love with his best friend. " +
                "The two are separated when the best friend falls for somebody else. However, Addison manages to rescue the situation by buying a magnificent t-shirt.",
                "https://bait.example.net/bag.aspx", new DateTime(2018, 07, 24), "https://cdn.pixabay.com/photo/2018/03/02/20/22/sktop-3194194__340.jpg"),

                new Book(3,author2, "NASA fed some Apollo 11 lunar samples to cockroaches and mice","Book", "A farmer from Markham is delighted when she gets the chance to take part " +
                "in the final of X-Factor. However, her chances are scuppered when her son goes missing. Unexpectedly, the farmer is bitten by a zombie and therefore is disqualified " +
                "from competing.", "https://www.example.com/bite.aspx", new DateTime(2006, 05, 15), "https://cdn.pixabay.com/photo/2016/08/18/08/31/lemur-1602313__340.jpg"),

                new Article(author3,  "When Your Smart ID Card Reader Comes with Malware", "Article", "In a world where robots are wealthy, one golfer has no choice but to assasinate an " +
                "honorable man by killing his own ex-wife. Eventually, the golfer forms an army and teaches the robots a little respect.", 
                "https://example.com/bone/basin.php?bed=bedroom&boat=amusement#boundary", date: new DateTime(2023, 03, 21),"https://cdn.pixabay.com/photo/2017/06/14/11/34/meadow-2401931__340.jpg"),

                new Book(3, author4,"Jailer: A truly relational database tool", "Book", "In a world where robots are wealthy, one golfer has no choice but to assasinate an honorable man by " +
                "killing his own ex-wife. Eventually, the golfer forms an army and teaches the robots a little respect.", "https://www.example.com/baseball/basin.php?attraction=anger&bead=amusement",
                new DateTime(1989, 06, 06), "https://cdn.pixabay.com/photo/2016/08/20/05/44/clock-1606919__340.jpg"),

                new Article(author5, "Everything you ever wanted to know about terminal", "Article", "In a world where robots are miraculously transformed into angels, one pop star has no " +
                "choice but to bring down the goverment by killing her own step-sister. It turns out all the robots were a manifestations of the pop star's multiple personality disorder " +
                "and her real fight is one to regain sanity.", "https://www.example.com/bait/bath.php", new DateTime(2020, 01, 23), "https://cdn.pixabay.com/photo/2016/09/01/10/33/witchs-house-1635770_960_720.jpg"), 
                
                new Article(author6, "NaturalSpeech: End-to-end text to speech synthesis with human-level quality", "Article", "When a movie star from West Des Moines learns to sing, not everybody" +
                " is supportive. However, her fortunes improve when her step-sister buys a deralict castle. Eventually, the movie star realises that she has always been a worthwhile person and does " +
                "not need to change.", "http://www.example.com/bear", new DateTime(2022, 10, 28), "https://cdn.pixabay.com/photo/2016/04/25/07/15/man-1351317__340.png")
            };
        }
    }
}