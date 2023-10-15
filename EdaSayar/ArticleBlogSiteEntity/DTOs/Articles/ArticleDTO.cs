using ArticleBlogSiteEntity.DTOs.Category;
using ArticleBlogSiteEntity.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteEntity.DTOs.Articles
{
    public class ArticleDTO
    {
		

		public int ID { get; set; }
        //public ArticleAddDTO Article { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public CategoryDTO Category { get; set; }
        public int ViewCount { get; set; }
        public bool IsDeleted { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Image { get; set; }
        public RatingValue Rating { get; set; }
        public string Comment { get; set; }
    }
}
