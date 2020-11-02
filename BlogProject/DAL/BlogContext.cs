using BlogProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BlogProject.DAL
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("BlogContext")
        {

        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}