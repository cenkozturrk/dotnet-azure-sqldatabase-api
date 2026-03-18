using Microsoft.EntityFrameworkCore;

namespace AzureSqlBlogApi.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Post> Posts
        {
            get;
            set;
        }
    }
}
