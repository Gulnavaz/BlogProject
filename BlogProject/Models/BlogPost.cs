using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogProject.Models
{
    public class BlogPost
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Datetime { get; set; }
        public string Category { get; set; }
        public string Text { get; set; }
    }
}