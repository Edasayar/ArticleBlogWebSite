using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteEntity.Entities
{
    public enum CategoryType {Tarih, Felsefe, Psikoloji, Teknoloji}
    public class Category:BaseEntity
    {
        
        public CategoryType CategoryType { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Article> Articles { get; set; }

        public Category()
        {
            Articles = new List<Article>();
        }
    }
}
