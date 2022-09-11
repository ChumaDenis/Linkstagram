using LinkstagramGFL.Models.Post.Comment;
using Microsoft.EntityFrameworkCore;

namespace LinkstagramGFL.Context
{
    public class CommentDbContext:DbContext
    {
        public CommentDbContext(DbContextOptions<CommentDbContext> options)
        : base(options)
        {
        }
        public DbSet<CommentInfo> Comments { get; set; }
        public DbSet<LikeUnderComment> LikeDetails { get; set; }
    }
}
