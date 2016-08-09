using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AngularMarkdownMedium.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [MaxLength, Required]
        public string Content { get; set; }

        public virtual Author Author { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}