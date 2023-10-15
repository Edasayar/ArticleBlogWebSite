using ArticleBlogSiteEntity.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteEntity.Entities
{
    public class Comment:BaseEntity
    {
        public string Content { get; set; } //içerik


        public virtual Article Article { get; set; }
        public int ArticleId { get; set; }


        //public virtual AppUser User  { get; set; }
        //public int UserId { get; set; }
       
       
    }
}
