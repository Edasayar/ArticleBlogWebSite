using ArticleBlogSiteEntity.DTOs.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteEntity.DTOs.Articles
{
    public class DetailArticleDTO
    {
        public int Content { get; set; }
        public CategoryDTO Category { get; set; }
        public int ViewCount { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Image { get; set; }
    }
}
