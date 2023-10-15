using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteEntity.DTOs
{
    public enum ResultStatus { Succes = 0, Error = 1, Warning = 2, Info = 3 }
    public abstract class DtoGetBase
    {
       
        public virtual ResultStatus ResultStatus { get; set; }
    }
}
