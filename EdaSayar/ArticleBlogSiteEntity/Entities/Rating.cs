using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteEntity.Entities
{
    public enum RatingValue { Bir=1,İki=2,Üç=3,Dört=4,Beş=5}
    public class Rating:BaseEntity
    {
        public int UserId { get; set; }

        public int ArticleId { get; set; }
        public int RatingId { get; set; }

        public RatingValue RatingValue { get; set; }
        //public virtual ICollection<Article> Articles  { get; set; }
        //public Rating()
        //{
        //      Articles = new List<Article>();
        //}


    }
}
