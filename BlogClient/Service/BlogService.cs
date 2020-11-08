using BlogClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlogClient.Service
{
    public class BlogService
    {
        static HttpClient httpClient = new HttpClient();
        private static string url = "http://localhost:44332/";

        public async Task<ObservableCollection<BlogPost>> GetBlogPosts()
        {
            string getPost = await httpClient.GetStringAsync(url + "api/blog");
            var blogs = JsonConvert.DeserializeObject<ObservableCollection<BlogPost>>(getPost);
            return blogs;
        }
        public async Task<ObservableCollection<BlogPost>> EditPostBlogs()
        {
            return null;
        }
        public async Task<ObservableCollection<BlogPost>> DeletePostBlogs()
        {
            return null;
        }
    }
}
