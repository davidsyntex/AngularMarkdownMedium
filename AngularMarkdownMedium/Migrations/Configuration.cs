using System.Collections.Generic;
using System.Data.Entity.Migrations;
using AngularMarkdownMedium.DataAccessLayer;
using AngularMarkdownMedium.Models;

namespace AngularMarkdownMedium.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MediumContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MediumContext context)
        {
            var tagNet = new Tag {Name = ".NET"};
            var tagCSharp = new Tag {Name = "C#"};
            var tagSD = new Tag {Name = "Software Development"};
            var tagWOW = new Tag {Name = "World of Warcraft"};
            var tagServers = new Tag {Name = "Servers"};

            var authorTobbe = new Author
            {
                Name = "Tobias Keijser",
                Byline = "StudentConsulting Keijser",
                TwitterHandle = "tkeijser"
            };
            var authorDave = new Author
            {
                Name = "David Malmström",
                Byline = "Presentation är viktigare än innehåll",
                TwitterHandle = "syradar"
            };

            var postLipsumNET = new Post
            {
                Author = authorTobbe,
                Content = "lorem ipsum",
                Title = "DOT NET LOREM LIPSUM",
                Tags = new List<Tag> {tagNet, tagCSharp, tagSD}
            };
            var postWOWBF = new Post
            {
                Author = authorDave,
                Content = "WOW to be ported to Brainfuck",
                Title = "Brainfuck WOW LOREM LIPSUM",
                Tags = new List<Tag> {tagSD, tagWOW, tagServers}
            };
            var postPrivServer = new Post
            {
                Author = authorDave,
                Content = "lorem ipsum",
                Title = "NEW WOW PRIVATE SERVER CORE IN .NET LOREM LIPSUM",
                Tags = new List<Tag> {tagCSharp, tagNet, tagServers, tagWOW}
            };

            context.Posts.AddOrUpdate(postPrivServer, postLipsumNET, postWOWBF);
        }
    }
}