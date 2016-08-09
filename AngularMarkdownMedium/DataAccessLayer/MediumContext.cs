using System.Data.Entity;
using AngularMarkdownMedium.Models;

namespace AngularMarkdownMedium.DataAccessLayer
{
    public class MediumContext : DbContext
    {
        public MediumContext() : base("DefaultConnection")
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}