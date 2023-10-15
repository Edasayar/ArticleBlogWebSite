using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.Utilities.Results.ComplexTypes
{
    public enum ResultStatus
    {
        Success = 0,
        Error = 1,
        Warning = 2,//ResultStatus.Warning arkada sayı içinde tutulacak
        Info = 3//ResultStatus.Info şeklinde işlem yapılır
    }
}

