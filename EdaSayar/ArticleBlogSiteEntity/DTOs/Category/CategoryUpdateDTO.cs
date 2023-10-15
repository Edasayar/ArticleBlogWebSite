using ArticleBlogSiteEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteEntity.DTOs.Category
{
    public class CategoryUpdateDTO
    {
        public int Id { get; set; }
        public virtual CategoryType CategoryType { get; set; }
    }
}
