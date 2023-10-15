using ArticleBlogSiteEntity.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteEntity.Identity
{
    public enum Role {Writer,Visitor,Admin,Reader}
    public class AppRole:IdentityRole<int>,IBaseEntity
    {
        public Role Role { get; set; }

    }
}
