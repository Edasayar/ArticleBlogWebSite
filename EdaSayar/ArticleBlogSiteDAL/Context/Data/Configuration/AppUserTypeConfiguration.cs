using ArticleBlogSiteEntity.Entities;
using ArticleBlogSiteEntity.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ArticleBlogSiteDAL.Context.Data.Configuration
{
    public class AppUserTypeConfiguration : IEntityTypeConfiguration<AppUser>
    {
        

        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
           
            builder.HasKey(u => u.Id);

            
           
            //builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
           // builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

          
            builder.ToTable("AspNetUsers");


            builder.HasData(new AppUser
            {
                Id = 1,
                UserName = "selino",
                FirstName="Selin",
                LastName="Öztürk",
                Email = "selino@gmail.com",
                PasswordHash = HashPassword("password123456789"),
                Image="image.jpg"
            },
            new AppUser
            {
                Id = 2,
                UserName = "admin",
				FirstName = "admin",
				LastName = "Admin",
				Email = "admin@gmail.com",
                PasswordHash = HashPassword("password123456789"),
                Image="image.jpg"

            }
            
            
            
            ) ;



        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}
