using ArticleBlogSiteEntity.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteEntity.Identity
{
    public class AppUser:IdentityUser<int>,IBaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }

        public int ConfirmCode { get; set; }

        public virtual ICollection<Rating> Ratingss { get; set; }
        public virtual ICollection<Comment> Commentss { get; set; }
      

        public AppUser()
        {
            Ratingss = new List<Rating>();
            Commentss = new List<Comment>();
          
        }

    }
}
