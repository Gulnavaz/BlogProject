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
using Windows.UI.Xaml.Navigation;

namespace BlogClient.ViewModels
{
    public class BlogPageViewModel
    {
        public ICommand BackBtn { get; set; }
        public ICommand EditBtn { get; set; }
        public BlogPost _blogPost { get; set; }
        public BlogPost Blog { get => _blogPost; set => _blogPost = value; }
        
        public BlogPageViewModel()
        {
            Blog = App.Blogpost;
            BackBtn = new RelayCommand(Back);
            EditBtn = new RelayCommand(EditBlog);
        }

        private void EditBlog()
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
