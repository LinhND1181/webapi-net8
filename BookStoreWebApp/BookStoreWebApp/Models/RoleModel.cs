﻿using BookStoreWebApp.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BookStoreWebApp.Models
{
    [Table("tblroles")]
    [Index(nameof(RoleModel.Name), IsUnique = false)]
    public class RoleModel : AbstractBaseModel
    {
        [Column("name"), Required, DisallowNull]
        public RoleEnum Name { get; set; }

        [Column("description"), DataType(DataType.Text)]
        public string Description { get; set; } = String.Empty;

        public Collection<UserRoleModel> RoleUsers { get; set; } = new Collection<UserRoleModel>();

    }
}
