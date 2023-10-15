using ArticleBlogSiteEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteEntity.DTOs.Category
{
    public class CategoryAddDTO
    {
        public virtual CategoryType CategoryType { get; set; }
    }
}
