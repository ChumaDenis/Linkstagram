using LinkstagramGFL.Models.Post;
using Microsoft.EntityFrameworkCore;

namespace LinkstagramGFL.Context
{
    public class PostDbContext : DbContext
    {
        public PostDbContext(DbContextOptions<PostDbContext> options)
        : base(options)
        {
        }
        public DbSet<PostInfo> Posts { get; set; }
        public DbSet<LikeDetails> LikeDetails { get; set; }
    }
}
