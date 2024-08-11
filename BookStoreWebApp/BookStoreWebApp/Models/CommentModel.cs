using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreWebApp.Models
{
    [Table("tblcomments")]
    public class CommentModel : AbstractBaseModel
    {
        [Required, Column("content"), DataType(DataType.Text)]
        public String Content { get; set; } = String.Empty;

        [Column("user_id"), ForeignKey("id")]
        public long UserId { get; set; }

        [Column("blog_id"), ForeignKey("id")]
        public long BlogId { get; set; }

        public UserModel User { get; set; } = new UserModel();

        public BlogModel Blog { get; set; } = new BlogModel();

    }
}
