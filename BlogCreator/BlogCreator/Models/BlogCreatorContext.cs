using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCreator.Models
{
    public class BlogCreatorContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public BlogCreatorContext(DbContextOptions<BlogCreatorContext> options)
            : base(options)
        {
        }
    }
}
