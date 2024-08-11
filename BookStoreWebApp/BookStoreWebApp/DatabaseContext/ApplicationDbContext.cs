using BookStoreWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreWebApp.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }


        // DbSet is to store the data we get after query
        public DbSet<CategoryModel> tblcategories { get; set; }
        public DbSet<BookModel> tblbooks { get; set; }
        public DbSet<UserModel> tblusers { get; set; }
        public DbSet<RoleModel> tblroles { get; set; }
        public DbSet<BlogModel> tblblog { get; set; }
        public DbSet<CommentModel> tblcomments { get; set; }

        // Configuring for Abstract Base Model for all other Models
        private void ConfigureBaseEntity<TAnyModel>(ModelBuilder modelBuilder) where TAnyModel : AbstractBaseModel{

            // Set created date to timestamp
            modelBuilder.Entity<TAnyModel>()
                .Property(abstractBase => abstractBase.CreatedDate)
                .HasColumnType("TIMESTAMP")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<TAnyModel>()
                .Property(abstractBase => abstractBase.UpdatedDate)
                .HasColumnType("TIMESTAMP")
                .HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ConfigureBaseEntity<UserModel>(modelBuilder);

            // Define text type for description field
            modelBuilder.Entity<CategoryModel>()
                 .Property(c => c.Description)
                 .HasColumnType("text");

            ConfigureBaseEntity<CategoryModel>(modelBuilder);

            modelBuilder.Entity<CategoryModel>()
                .HasMany(cate => cate.Books)        // Define one category has many book relationship
                .WithOne(book => book.Category)     // Define the inverse relationship (the list)
                .HasForeignKey(book => book.CategoryId)     // Set foreign key category id for book table
                .OnDelete(DeleteBehavior.Cascade);  // Enable cascade delete meaning when deleting a category,
                                                    // We delete the whole book belongs to that category

            ConfigureBaseEntity<BookModel>(modelBuilder);

            // User and Role Many to Many relationship set up
            modelBuilder.Entity<UserModel>()
                .HasMany(user => user.UserRoles)
                .WithOne(userRole => userRole.User)
                .HasForeignKey(userRole => userRole.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RoleModel>()
                .HasMany(role => role.RoleUsers)
                .WithOne(userRole => userRole.Role)
                .HasForeignKey(userRole => userRole.RoleId)
                .OnDelete(DeleteBehavior.NoAction);

            // Apply UserId and RoleId as couple of primary key for UserRoleModel
            modelBuilder.Entity<UserRoleModel>(x => x.HasKey(p => new { p.UserId, p.RoleId }));

            // Configure model builder for user model
            modelBuilder.Entity<UserModel>()
                .HasMany(user => user.Blogs)
                .WithOne(blog => blog.User)
                .HasForeignKey(blog => blog.UserId);

            // User and Blog Many to Many set up as Table comment
            modelBuilder.Entity<UserModel>()
                .HasMany(user => user.Comments)
                .WithOne(comment => comment.User)
                .HasForeignKey(comment => comment.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BlogModel>()
                .HasMany(blog => blog.Comments)
                .WithOne(comment => comment.Blog)
                .HasForeignKey(comment => comment.BlogId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
