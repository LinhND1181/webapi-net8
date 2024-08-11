using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Version4_UpdateBlog_AddComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "tblblogs",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tblcomments",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    blog_id = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_tblcomments", x => x.id);
                    table.ForeignKey(
                        name: "FK_tblcomments_tblblogs_blog_id",
                        column: x => x.blog_id,
                        principalTable: "tblblogs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblcomments_tblusers_user_id",
                        column: x => x.user_id,
                        principalTable: "tblusers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_tblblogs_title",
                table: "tblblogs",
                column: "title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblcomments_blog_id",
                table: "tblcomments",
                column: "blog_id");

            migrationBuilder.CreateIndex(
                name: "IX_tblcomments_user_id",
                table: "tblcomments",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblcomments");

            migrationBuilder.DropIndex(
                name: "IX_tblblogs_title",
                table: "tblblogs");

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "tblblogs",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
