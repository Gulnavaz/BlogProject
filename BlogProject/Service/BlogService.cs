using BlogProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace BlogProject.Service
{
    public class BlogService
    {
        static HttpClient httpClient = new HttpClient();
        private static string GetPostBlogs = "https://localhost:44357";
        private static string EditPostBlogs = "https://localhost:44357";
        private static string DeletePostBlogs = "https://localhost:44357";
        public async Task<ObservableCollection<BlogPost>> GetPostBlogs()
        {
            
        }
        public async Task<ObservableCollection<BlogPost>> EditPostBlogs()
        {

        }
        public async Task<ObservableCollection<BlogPost>> DeletePostBlogs()
        {

        }
    }
}