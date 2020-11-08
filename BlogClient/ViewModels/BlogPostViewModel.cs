using BlogClient.Models;
using BlogClient.Service;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;

namespace BlogClient.ViewModels
{
    public class BlogPostViewModel
    {
        BlogService blogService;
        public ObservableCollection<BlogPost> _blogs { get; set; }
        public ObservableCollection<BlogPost> Blogs { get => _blogs; set => _blogs = value; }
        public BlogPost _selected { get; set; }
        public BlogPost Selected { get => _selected; set => _selected = value; }
        public ICommand RemoveBtn { get; set; }
        public ICommand ReadMoreBtn { get; set; }
        public ICommand AddBtn { get; set; }

        public BlogPostViewModel()
        {
            Selected = new BlogPost();
            blogService = new BlogService();
            try
            {
                System.Threading.Thread.Sleep(3000);
                var data = GetBlog();
                Blogs = new ObservableCollection<BlogPost>(data.OrderBy(x => x.Datetime));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            RemoveBtn = new RelayCommand(Remove);
            ReadMoreBtn = new RelayCommand(ReadMore);
            AddBtn = new RelayCommand(AddBlog);
        }

        private void AddBlog()
        {
            var nav = ServiceLocator.Current.GetInstance<INavigationService>();
            nav.NavigateTo(App.NewBlog);
        }

        private void ReadMore()
        {
            var nav = ServiceLocator.Current.GetInstance<INavigationService>();
            App.Blogpost = Selected;
            nav.NavigateTo(App.BlogPage);
        }

        private void Remove()
        {
            var test = Task.Run(async () => await blogService.DeletePostBlogs(Selected.ID)).GetAwaiter().GetResult();
            Blogs.Clear();
            var data = GetBlog().OrderBy(x => x.Datetime);
            foreach (var item in data)
            {
                Blogs.Add(item);
            }
        }
        private ObservableCollection<BlogPost> GetBlog()
        {
            var data = Task.Run(async () => await blogService.GetBlogPosts()).GetAwaiter().GetResult();
            return data;
        }
    }
}
