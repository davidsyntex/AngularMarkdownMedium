using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AngularMarkdownMedium.DataAccessLayer;
using AngularMarkdownMedium.Models;

namespace AngularMarkdownMedium.Repositories
{
    internal class PostRepository
    {
        private readonly MediumContext _context;

        public PostRepository()
        {
            _context = new MediumContext();
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts.Include(p => p.Author).Include(p => p.Tags);
        }
    }
}