using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCreator.Models
{
    public class DbInitializer
    {
        public static void Initialize(BlogCreatorContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
            new User{ UserId =1,UserName ="Helen",Email ="helen@gmail.com",Phone="0500765616",Avatar="helen.jpg"}
           
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var blogs = new Blog[]
            {
            new Blog{BlogId=1,BlogName="BlogName",BlogDescription="BlogDescription",SectionsName="SectionsName",DateCreated=DateTime.Parse("2005-09-01"),UserId=1}
           
            };
            foreach (Blog b in blogs)
            {
                context.Blogs.Add(b);
            }
            context.SaveChanges();

            var comments = new Comment[]
            {
            new Comment{ CommentId =1,CommentDescription="CommentDescription",UserName="UserName",BlogId=1}
          
            };
            foreach (Comment c in comments)
            {
                context.Comments.Add(c);
            }
            context.SaveChanges();
        }
    }
}
