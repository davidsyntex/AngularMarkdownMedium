using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace AngularMarkdownMedium.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [JsonIgnore]
        public virtual ICollection<Post> Posts { get; set; }
    }
}