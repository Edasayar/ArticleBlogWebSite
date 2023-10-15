using ArticleBlogSiteEntity.DTOs.Category;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ArticleBlogSiteEntity.DTOs.Articles
{
    public class ArticleUpdateDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }

        public string Image { get; set; }
        public IFormFile? Photo { get; set; }

        public IList<CategoryDTO> Categories { get; set; }
    }
}
