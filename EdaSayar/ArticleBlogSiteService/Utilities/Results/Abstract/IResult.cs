using ArticleBlogSiteService.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; } //ResultStatus.Success veya .Error
        public string Message { get; }
        public Exception Exception { get; }//Değiştirilebilir olmayacak
    }
}
