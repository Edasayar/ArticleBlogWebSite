using ArticleBlogSiteEntity.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteDAL.Context.Data.Configuration
{
    public class AppRoleTypeConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {

            builder.HasKey(r => r.Id);
            builder.Property(x => x.Role).HasConversion(new EnumToStringConverter<Role>());


            builder.HasData(new AppRole
            {
                Id=-1,
                Role=Role.Admin
              


            },
           new AppRole
           {
           
               Id = -2,
               Role = Role.Writer

           },
           new
           {
              Id = -3,
               Role = Role.Reader


           },
           new
           {
               Id = -4,
               Role = Role.Visitor

           });


        }
        //private string CreatePasswordHash(AppUser user, string password)
        //{
        //    var passwordHasher = new PasswordHasher<AppUser>();
        //    return passwordHasher.HashPassword(user, password);
        //}
    }


}      
    

