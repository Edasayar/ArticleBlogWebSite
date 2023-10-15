using ArticleBlogSiteDAL.UnitOfWorks;
using ArticleBlogSiteEntity.DTOs.Articles;
using ArticleBlogSiteEntity.DTOs.Category;
using ArticleBlogSiteEntity.Entities;
using ArticleBlogSiteService.Extensions;
using ArticleBlogSiteService.Services.Abstract;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ArticleBlogSiteService.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ClaimsPrincipal _user;
        public CategoryService(IHttpContextAccessor httpContextAccessor, IUnitOfWork uniteOfWork, IMapper mapper)
        {
            _unitOfWork = uniteOfWork;
            _mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
        }
        public Task<List<CategoryDTO>> AddCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task CreateCategoryAsync(CategoryDTO categoryAddDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDTO>> GetAllCategoriesDeleted()
        {
            throw new NotImplementedException();
        }

        public async Task<List<CategoryDTO>> GetAllCategoriesNonDeleted()
        {
            var categories = await _unitOfWork.GetRepository<Category>().GetAllAsync(x => !x.IsDeleted);
            var map = _mapper.Map<List<CategoryDTO>>(categories);

            return map;
        }

        public async Task<List<CategoryDTO>> GetAllCategoriesNonDeletedTake24()
        {
            var categories = await _unitOfWork.GetRepository<Category>().GetAllAsync(x => !x.IsDeleted);
            var map = _mapper.Map<List<CategoryDTO>>(categories);

            return map.Take(24).ToList();
        }

        public async Task<List<CategoryDTO>> GetAllCategoryAsync()
        {
            var category = await _unitOfWork.GetRepository<Category>().GetAllAsync();
            var map = _mapper.Map<List<CategoryDTO>>(category);
            return map;
        }

        public Task<List<CategoryDTO>> GetCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            var category = await _unitOfWork.GetRepository<Category>().GetByIntAsync(id);
            return category;
        }

        public Task<string> SafeDeleteCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<string> UndoDeleteCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }



        public async Task<string> UpdateCategoryAsync(CategoryUpdateDTO categoryUpdateDto)
        {
            //var userEmail = _user.GetLoggedInEmail();
            //var category = await _unitOfWork.GetRepository<Category>().GetAsync(x => !x.IsDeleted && x.ID == categoryUpdateDto.Id);

            //category.CategoryType = categoryUpdateDto.CategoryType;
            //category.ModifiedBy = userEmail;
            //category.ModifiedDate = DateTime.Now;


            //await _unitOfWork.GetRepository<Category>().UpdateAsync(category);
            //await _unitOfWork.SaveAsync();


            throw new NotImplementedException();
        }


    }
}
