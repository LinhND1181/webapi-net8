using BookStoreWebApp.Domain.Entities;
using System.Collections;
using System.Collections.ObjectModel;

namespace BookStoreWebApp.Repositories
{
    public interface ICategoryRepository
    {

        Task<List<CategoryModel>> getAllCategoriesAsync();
    }
}
