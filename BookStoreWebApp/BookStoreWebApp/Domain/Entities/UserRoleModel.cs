using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreWebApp.Domain.Entities
{
    [Table("tblusers_roles")]
    public class UserRoleModel
    {
        [Column("user_id"), ForeignKey("id")]
        public long UserId { get; set; }

        [Column("role_id"), ForeignKey("id")]
        public long RoleId { get; set; }

        public UserModel User { get; set; } = new UserModel();

        public RoleModel Role { get; set; } = new RoleModel();

    }
}
