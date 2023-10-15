using ArticleBlogSiteEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteEntity.DTOs.Articles
{
    public class ArticleListDTO
    {
        public IList<Article> Articles { get; set; }
        public virtual int TotalCount { get; set; }
        public virtual int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalCount, PageSize));
        public virtual int CurrentPage { get; set; } = 1;
        public virtual bool IsAscending { get; set; } = false;
        public virtual int PageSize { get; set; } = 3;
        public virtual bool ShowNext => CurrentPage < TotalPages;
        public int? CategoryId { get; set; }
    }
}
