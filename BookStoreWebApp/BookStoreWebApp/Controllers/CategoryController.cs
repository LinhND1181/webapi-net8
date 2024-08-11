using BookStoreWebApp.Domain.Entities;
using BookStoreWebApp.Repositories;
using BookStoreWebApp.Repositories.Implements;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreWebApp.Controllers
{
    
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository) {
            _categoryRepository = categoryRepository;
        }

        /// <summary>
        /// Retrieves a list of all categories.
        /// </summary>
        /// <remarks>
        /// This endpoint returns a list of categories available in the system.
        /// </remarks>
        /// <returns>A list of categories.</returns>
        /// <response code="200">Returns the list of categories.</response>
        /// <response code="404">If no categories are found.</response>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<CategoryModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> getAllCategories()
        {
            var categoryList = await _categoryRepository.getAllCategoriesAsync();
            return Ok(categoryList);
        }

    }
}
