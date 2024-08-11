using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BookStoreWebApp.Models
{
    [Table("tblcategories")]
    [Index(nameof(CategoryModel.Name), IsUnique = true)]
    public class CategoryModel : AbstractBaseModel
    {

        [Required, Column("name"), DisallowNull]
        public string Name { get; set; } = string.Empty;

        [Column("description"), DataType(DataType.Text)]
        public string Description { get; set; } = string.Empty;

        public List<BookModel> Books { get; set; } = new List<BookModel>();


    }
}
