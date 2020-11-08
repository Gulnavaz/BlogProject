using BlogClient.Service;
using BlogClient.Models;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BlogClient.ViewModels
{
    public class NewBlogViewModel
    {
        BlogService blogService;
        public ICommand BackBtn { get; set; }
        public ICommand AddBtn { get; set; }
        public BlogPost _blogPost { get; set; }
        public BlogPost Blog { get => _blogPost; set => _blogPost = value; }
        public NewBlogViewModel()
        {
            Blog = App.Blogpost;
            blogService = new BlogService();
            BackBtn = new RelayCommand(Back);
            AddBtn = new RelayCommand(AddNewBlog);
        }
        private void AddNewBlog()
        {
            throw new NotImplementedException();
        }

        private void Back()
        {
            var nav = ServiceLocator.Current.GetInstance<INavigationService>();
            nav.NavigateTo(App.MainPage);
        }
    }
}
