using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreWebApp.Domain.Entities
{
    [Table("tblblogs")]
    [Index(nameof(Title), IsUnique = true)]
    public class BlogModel : AbstractBaseModel
    {
        [Required, Column("title")]
        public string Title { get; set; } = string.Empty;

        [Column("content"), DataType("TEXT")]
        public string Content { get; set; } = string.Empty;

        [Column("summary"), DataType("TEXT")]
        public string Summary { get; set; } = string.Empty;

        [Column("thumbnail")]
        public string Thumbnail { get; set; } = string.Empty;

        [Column("user_id")]
        public long UserId { get; set; }

        public UserModel User { get; set; } = new UserModel();

        public Collection<CommentModel> Comments { get; set; } = new Collection<CommentModel>();

    }
}
