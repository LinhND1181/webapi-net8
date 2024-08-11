using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreWebApp.Models
{
    [Table("tblblogs")]
    [Index(nameof(BlogModel.Title), IsUnique = true)]
    public class BlogModel : AbstractBaseModel
    {
        [Required, Column("title")]
        public String Title { get; set; } = String.Empty;

        [Column("content"), DataType("TEXT")]
        public String Content { get; set; } = String.Empty;

        [Column("summary"), DataType("TEXT")]
        public String Summary { get; set; } = String.Empty;

        [Column("thumbnail")]
        public String Thumbnail { get; set; } = String.Empty;

        [Column("user_id")]
        public long UserId { get; set; }

        public UserModel User { get; set; } = new UserModel();

        public Collection<CommentModel> Comments { get; set; } = new Collection<CommentModel>();

    }
}
