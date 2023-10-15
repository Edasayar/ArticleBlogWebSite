using ArticleBlogSiteDAL.Context.Data.Configuration;
using ArticleBlogSiteEntity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteDAL.Context
{
    public class ArticleBlogSiteDbContext: DbContext
    {
  

        public ArticleBlogSiteDbContext(DbContextOptions<ArticleBlogSiteDbContext> options) : base(options)
        {
              
        }

		public ArticleBlogSiteDbContext()
		{
		}

		public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Rating> Ratingss { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.ApplyConfiguration(new ArticleTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CommentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RatingTypeConfiguration());
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }


    }
}
