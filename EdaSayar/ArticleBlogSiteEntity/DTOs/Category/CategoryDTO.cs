using ArticleBlogSiteEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteEntity.DTOs.Category
{
    
    public class CategoryDTO
    {
        public virtual CategoryType CategoryType  { get; set; }
        public string Description { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
    }
}
