using BookStoreWebApp.DatabaseContext;
using BookStoreWebApp.Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;

namespace BookStoreWebApp.Repositories.Implements
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly ApplicationDbContext _dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<CategoryModel>> getAllCategoriesAsync()
        {
            return await _dbContext.Categories.ToListAsync();
        }
    }
}
