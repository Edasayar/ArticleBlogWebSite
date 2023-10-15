using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteEntity.DTOs.Comment
{
    public class CommentDTO
    {
       
        public string Content { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
    }
}
