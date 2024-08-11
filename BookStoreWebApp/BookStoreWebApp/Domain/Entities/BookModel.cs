using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreWebApp.Domain.Entities
{
    [Table("tblbooks")]
    public class BookModel : AbstractBaseModel
    {

        [Column("category_id"), ForeignKey("id")]
        public long CategoryId { get; set; }        // Foreign Key

        public CategoryModel? Category { get; set; } = new CategoryModel();

    }
}
