﻿// <auto-generated />
using System;
using BookStoreWebApp.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStoreWebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240810194451_Version3_AddBlogModel")]
    partial class Version3_AddBlogModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("BookStoreWebApp.Models.BlogModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("ActiveFlag")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_flag");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("content");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("delete_flag");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("summary");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("thumbnail");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("title");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("updated_by");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_date");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("tblblogs");
                });

            modelBuilder.Entity("BookStoreWebApp.Models.BookModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("ActiveFlag")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_flag");

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint")
                        .HasColumnName("category_id");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("created_date")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("delete_flag");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("updated_by");

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("updated_date")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("tblbooks");
                });

            modelBuilder.Entity("BookStoreWebApp.Models.CategoryModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("ActiveFlag")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_flag");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("created_date")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("delete_flag");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("updated_by");

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("updated_date")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("tblcategories");
                });

            modelBuilder.Entity("BookStoreWebApp.Models.RoleModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("ActiveFlag")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_flag");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("delete_flag");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<int>("Name")
                        .HasColumnType("int")
                        .HasColumnName("name");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("updated_by");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_date");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("tblroles");
                });

            modelBuilder.Entity("BookStoreWebApp.Models.UserModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("ActiveFlag")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("active_flag");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("address");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("created_date")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("delete_flag");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("full_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("password");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)")
                        .HasColumnName("phone_number");

                    b.Property<string>("Refreshtoken")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("refresh_token");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("updated_by");

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasColumnName("updated_date")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("tblusers");
                });

            modelBuilder.Entity("BookStoreWebApp.Models.UserRoleModel", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint")
                        .HasColumnName("role_id");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("tblusers_roles");
                });

            modelBuilder.Entity("BookStoreWebApp.Models.BlogModel", b =>
                {
                    b.HasOne("BookStoreWebApp.Models.UserModel", "User")
                        .WithMany("Blogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookStoreWebApp.Models.BookModel", b =>
                {
                    b.HasOne("BookStoreWebApp.Models.CategoryModel", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BookStoreWebApp.Models.UserRoleModel", b =>
                {
                    b.HasOne("BookStoreWebApp.Models.RoleModel", "Role")
                        .WithMany("RoleUsers")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("BookStoreWebApp.Models.UserModel", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookStoreWebApp.Models.CategoryModel", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookStoreWebApp.Models.RoleModel", b =>
                {
                    b.Navigation("RoleUsers");
                });

            modelBuilder.Entity("BookStoreWebApp.Models.UserModel", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
