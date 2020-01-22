using System;
using Forum.Data.Models;
using Forum.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Forum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var context = new ForumDBContext();

            ResetDatabase(context);
            // var categories = context.Categories.Include(c => c.Posts).ThenInclude(p => p.Author).Include(c=>c.Posts).ThenInclude(p=>p.Replies).ThenInclude(r=>r.Author).ToArray();

            var categories = context.Categories.Select(c => new 
            { Name = c.Name, Posts = c.Posts.Select(p => new
            { Title = p.Title, Content = p.Content, AuthorUsername = p.Author.Username, Replies = p.Replies.Select(r => new
            { Content = r.Content, Author = r.Author.Username }).ToArray() }).ToArray() }).ToArray();

            foreach (var category in categories)
            {
                Console.WriteLine($"{category.Name} ({category.Posts.Count()})");

                foreach (var post in category.Posts)
                {
                    Console.WriteLine($"--{post.Title}: {post.Content}");
                    Console.WriteLine($"--by {post.AuthorUsername}");

                    foreach (var reply in post.Replies)
                    {
                        Console.WriteLine($"----{reply.Content} from {reply.Author}");
                    }
                }
            }

            
        }

        private static void ResetDatabase(ForumDBContext context)
        {
            context.Database.EnsureCreated();
            context.Database.Migrate();

            Seed(context);
        }

        private static void Seed(ForumDBContext context)
        {
            var users = new[]
            {
                new User("Pesho","123"),
                new User("Gosho","123"),
                new User("Ivan","123"),
                new User("Merry","123")

            };

            var categories = new[]
            {
                new Category("C#"),
                new Category("Support"),
                new Category("Python")
            };

            var posts = new[]
            {
                new Post("C# Rulz","true story",categories[0], users[0]),
                new Post("Python Rulz","mhm",categories[1], users[1]),
                new Post("BBHMM","sup",categories[2], users[3]),

            };

            var replies = new[]
            {
                new Reply("Turn it on",posts[2], users[0]),
                new Reply("Yep",posts[0], users[3])
        };
            var tags = new[]
            {
                new Tag("C#" ),
                new Tag("Programming" ),
                new Tag("Python" ),
                new Tag("Microsoft" ),

            };

            var postTags = new[]
            {
                new PostTag(){PostId = 1, Tag = tags[0] },
                new PostTag(){PostId = 1, Tag = tags[1] },
                new PostTag(){PostId = 1, Tag = tags[2] },
                new PostTag(){PostId = 1, Tag = tags[3] },
            };
            context.Users.AddRange(users);
            context.Categories.AddRange(categories);
            context.Posts.AddRange(posts);
            context.Replies.AddRange(replies);
            context.Tags.AddRange(tags);
            context.PostTags.AddRange(postTags);
            context.SaveChanges();
        }
    }
}
