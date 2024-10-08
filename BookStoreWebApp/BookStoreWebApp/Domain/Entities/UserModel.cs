﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreWebApp.Domain.Entities
{
    [Table("tblusers")]
    [Index(nameof(Email), IsUnique = true)]
    public class UserModel : AbstractBaseModel
    {
        [Column("address")]
        public string Address { get; set; } = string.Empty;

        // EmailAddress: performs validation during model binding, and it's typically used in conjunction with model validation
        // DataType.EmailAddress: this field should be treated with an email address format and trigger email-specific input behaviour
        [Required, Column("email"), EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        [Required, Column("full_name"), MaxLength(50)]
        public string FullName { get; set; } = string.Empty;


        // DataType.Password: this field should be treated with an passwrod format and trigger password input behaviour
        [Required, Column("password"), MaxLength(20), DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required, Column("phone_number"), Phone, MaxLength(12), DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required, Column("refresh_token")]
        public string Refreshtoken { get; set; } = string.Empty;

        public Collection<BlogModel> Blogs { get; set; } = new Collection<BlogModel>();

        public Collection<UserRoleModel> UserRoles { get; set; } = new Collection<UserRoleModel>();

        public Collection<CommentModel> Comments { get; set; } = new Collection<CommentModel>();
    }

}
