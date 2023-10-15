using ArticleBlogSiteEntity.DTOs.Category;

namespace ArticleBlogSiteMVC.Areas.Admin.Models.DTOs
{
	public class ArticleAddDTO
	{
		public int ID { get; set; }
		//public ArticleAddDTO Article { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public CategoryDTO Category { get; set; }
		public int ViewCount { get; set; }
		public bool IsDeleted { get; set; }
		public virtual string CreatedBy { get; set; }
		public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
		public string Image { get; set; }
	}
}
