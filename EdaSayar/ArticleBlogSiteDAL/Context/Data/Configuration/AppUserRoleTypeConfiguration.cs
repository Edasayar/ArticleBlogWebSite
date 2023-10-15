
using ArticleBlogSiteEntity.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteDAL.Context.Data.Configuration
{
    public class AppUserRoleTypeConfiguration : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            //builder.HasData(new AppUserRole
            //{
            //    UserId = -1, //admin

            //    RoleId = -1, //Admin

            //},
            //new AppUserRole
            //{
            //    UserId = -2, //dilo
            //    RoleId = -2 //Yazar
            //},
            //new AppUserRole
            //{
            //    UserId = -3, //batu
            //    RoleId = -2  //yazar  
            //},
            //new AppUserRole
            //{
            //    UserId = -4,  //selino
            //    RoleId = -2 //yazar
            //}


            //);
        }
    }
}
