using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace AngularMarkdownMedium.Models
{
    public class Author
    {
        public Author()
        {
            Posts = new List<Post>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string TwitterHandle { get; set; }
        public string Byline { get; set; }
        [JsonIgnore]
        public virtual ICollection<Post> Posts { get; set; }
    }
}