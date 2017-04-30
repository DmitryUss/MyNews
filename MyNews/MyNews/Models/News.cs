using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyNews.Models
{
    public class News
    {
        public int Id { get; set; }
        public string NewsName { get; set; }
        public string NewsText { get; set; }

        public ICollection<Comment> Comment { get; set; }

        public News()
        {
            Comment = new List<Comment>();
        }

    }
}