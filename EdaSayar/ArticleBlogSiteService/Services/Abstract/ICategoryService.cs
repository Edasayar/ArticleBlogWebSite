using ArticleBlogSiteEntity.DTOs.Articles;
using ArticleBlogSiteEntity.DTOs.Category;
using ArticleBlogSiteEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.Services.Abstract
{
    public interface ICategoryService
    {
        Task<List<CategoryDTO>> GetAllCategoriesNonDeleted();
        Task<List<CategoryDTO>> GetAllCategoriesNonDeletedTake24();
        Task<List<CategoryDTO>> GetAllCategoriesDeleted();
        Task CreateCategoryAsync(CategoryDTO categoryAddDto);
        Task<Category> GetCategoryById(int id);
        Task<string> UpdateCategoryAsync(CategoryUpdateDTO categoryUpdateDto);
        Task<string> SafeDeleteCategoryAsync(int categoryId);
        Task<string> UndoDeleteCategoryAsync(int categoryId);




    }
}
