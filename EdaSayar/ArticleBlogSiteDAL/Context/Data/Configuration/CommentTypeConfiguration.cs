using ArticleBlogSiteEntity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteDAL.Context.Data.Configuration
{
    public class CommentTypeConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID)
                   .UseIdentityColumn(1, 1);

            builder.Property(x => x.Content).HasMaxLength(200);

            builder.HasOne(x => x.Article).WithMany(x => x.Comments).HasForeignKey(x => x.ArticleId).OnDelete(DeleteBehavior.NoAction);


            builder.HasData(new Comment
            {
                ID = 1,
                ArticleId = 1,
                Content = "Yorumcghfghfj",
             
                CreatedDate = DateTime.Now,
                CreatedBy = "kardelen3@mail.com",
                IsDeleted = false,
              



            },
            new Comment
            {
                ID = 2,
                ArticleId = 2,
                Content = "Yorughfgjnfhjm",
              
                CreatedDate = DateTime.Now,
                CreatedBy = "dilo@gmail.com",
                IsDeleted = false,
              
            },
            new Comment
            {
                ID = 3,
                ArticleId = 1,
                Content = "Yorgvjngyhjukum",
              
                CreatedDate = DateTime.Now,
                CreatedBy = "dünya@gmail.com",
                IsDeleted = false,
               
            },
            new Comment
            {
                ID = 4,
                ArticleId = 1,
                Content = "içerik dfldkf",
             
                CreatedDate = DateTime.Now,
                CreatedBy = "User@gmail.com",
                IsDeleted = false,
              
            },
            new Comment
            {
                ID = 5,
                ArticleId = 1,
                Content = "içerik",
               
                CreatedDate = DateTime.Now,
                CreatedBy = "leyla@gmail.com",
                IsDeleted = false,
               
            }


            );
        }
    }
}
