using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TehranPosts.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
namespace TehranPosts.Data
{
    public class AppDbContext : DbContext
    {
        public static string ConStr = "Data Source=WorkEscape; Initial Catalog=TehranPosts;Integrated Security=True;";
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EntityTypeConfigurations.PostMap());
            builder.ApplyConfiguration(new EntityTypeConfigurations.UserMap());
            builder.ApplyConfiguration(new EntityTypeConfigurations.BlogMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(ConStr);
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<AppDbContext> optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(AppDbContext.ConStr);
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}