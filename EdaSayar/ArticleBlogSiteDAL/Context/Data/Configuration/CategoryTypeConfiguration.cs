using ArticleBlogSiteEntity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteDAL.Context.Data.Configuration
{
    public class CategoryTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID)
                   .UseIdentityColumn(1, 1);

            builder.Property(x => x.CategoryType).HasConversion(new EnumToStringConverter<CategoryType>());


            builder.HasData(new Category
            {
                ID = 1,
                CategoryType=CategoryType.Psikoloji,
                CreatedDate = DateTime.Now,
                Description = "fgbdcfb",
                CreatedBy = "Admin",

                IsDeleted = false

            },
            new Category
            {
                ID = 2,
                CategoryType = CategoryType.Felsefe,
                CreatedDate = DateTime.Now,
                Description = "cfvbf",
                CreatedBy = "Admin",

                IsDeleted = false
            },

            new Category
            {
                ID = 3,
                CategoryType = CategoryType.Tarih,
                CreatedDate = DateTime.Now,
                Description = "fsdbf",
                CreatedBy = "Admin",

                IsDeleted = false
            },
             new Category
             {
                 ID = 4,
                 CategoryType = CategoryType.Teknoloji,
                 CreatedDate = DateTime.Now,
                 Description = "fsdbf",
                 CreatedBy = "Admin",

                 IsDeleted = false
             }


            );


        }
    }
}
