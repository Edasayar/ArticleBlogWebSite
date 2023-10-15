using ArticleBlogSiteEntity.Entities;
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
    public class RatingTypeConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.Property(x => x.RatingValue).HasConversion(new EnumToStringConverter<RatingValue>());
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID)
                   .UseIdentityColumn(1, 1);

            //builder.HasMany(x => x.Articles).
            //  WithOne(x => x.Rating).HasForeignKey(x => x.RatingId).OnDelete(DeleteBehavior.NoAction);



            builder.HasData(new Rating
            {
                ID = 1,
                UserId = -1,
                ArticleId = 3,
                CreatedBy = "User4",
                CreatedDate = DateTime.Now,
                IsDeleted = true,
                RatingValue = RatingValue.Üç

            },

            new Rating
            {
                ID = 2,
                UserId = -2,
                ArticleId = 6,
                CreatedBy = "User1",
                CreatedDate = DateTime.Now,
                IsDeleted = true,
                RatingValue = RatingValue.İki
            },

             new Rating
             {
                 ID = 3,
                 UserId = -2,
                 ArticleId = 2,
                 CreatedBy = "User2",
                 CreatedDate = DateTime.Now,
                 IsDeleted = true,
                 RatingValue = RatingValue.Beş
             },

              new Rating
              {
                  ID = 4,
                  UserId = -3,
                  ArticleId = 1,
                  CreatedBy = "User3",
                  CreatedDate = DateTime.Now,
                  IsDeleted = true,
                  RatingValue = RatingValue.Bir
              },

               new Rating
               {
                   ID = 5,
                   UserId = -2,
                   ArticleId = 3,
                   CreatedBy = "User5",
                   CreatedDate = DateTime.Now,
                   IsDeleted = true,
                   RatingValue = RatingValue.Beş
               },

                new Rating
                {
                    ID = 6,
                    UserId = -3,
                    ArticleId = 4,
                    CreatedBy = "User6",
                    CreatedDate = DateTime.Now,
                    IsDeleted = true,
                    RatingValue = RatingValue.Dört
                }

            );
        }
    }
}
