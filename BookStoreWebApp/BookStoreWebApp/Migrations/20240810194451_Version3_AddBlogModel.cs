using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Version3_AddBlogModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "tblusers",
                newName: "full_name");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tblcategories",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "tblcategories",
                newName: "description");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "tblusers",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "tblcategories",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tblblogs",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    summary = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    thumbnail = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    active_flag = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    delete_flag = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    created_by = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    updated_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_by = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblblogs", x => x.id);
                    table.ForeignKey(
                        name: "FK_tblblogs_tblusers_user_id",
                        column: x => x.user_id,
                        principalTable: "tblusers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_tblusers_email",
                table: "tblusers",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblroles_name",
                table: "tblroles",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "IX_tblcategories_name",
                table: "tblcategories",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblblogs_user_id",
                table: "tblblogs",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblblogs");

            migrationBuilder.DropIndex(
                name: "IX_tblusers_email",
                table: "tblusers");

            migrationBuilder.DropIndex(
                name: "IX_tblroles_name",
                table: "tblroles");

            migrationBuilder.DropIndex(
                name: "IX_tblcategories_name",
                table: "tblcategories");

            migrationBuilder.RenameColumn(
                name: "full_name",
                table: "tblusers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "tblcategories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "tblcategories",
                newName: "Description");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "tblusers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "tblcategories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
