using BlogClient.Models;
using BlogClient.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogClient.ViewModels
{
    public class BlogPostViewModel
    {
        BlogService blogService;
        public ObservableCollection<BlogPost> _blogs { get; set; }
        public ObservableCollection<BlogPost> Blogs { get => _blogs; set => _blogs = value; }

        public BlogPostViewModel()
        {
            blogService = new BlogService();
            Blogs = new ObservableCollection<BlogPost>();
            Blogs = Task.Run(async () => await blogService.GetBlogPosts()).GetAwaiter().GetResult();

        }
    }
}
