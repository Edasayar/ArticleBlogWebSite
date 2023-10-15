using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteEntity.Entities
{
    public class Article:BaseEntity
    { //makale
        public string Title { get; set; } //başlık
        public string Content { get; set; } //içerik
      
        public int UserId { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public string Image { get; set; }
        public int ViewCount { get; set; }



        
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }


        public Article()
        {
            Comments = new List<Comment>();
            Ratings = new List<Rating>();
           
            
        }


    }
}
