using ArticleBlogSiteEntity.DTOs.Category;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteEntity.DTOs.Articles
{
    public class ArticleAddDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }

        public IList<CategoryDTO> Categories { get; set; }
    }
}
