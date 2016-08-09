using System.Collections.Generic;
using System.Web.Http;
using AngularMarkdownMedium.Models;
using AngularMarkdownMedium.Repositories;

namespace AngularMarkdownMedium.Controllers
{
    public class PostsController : ApiController
    {
        private readonly PostRepository _repo;

        public PostsController()
        {
            _repo = new PostRepository();
        }

        // GET api/posts
        public IEnumerable<Post> Get()
        {
            return _repo.GetAll();
        }

        // GET api/posts/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
