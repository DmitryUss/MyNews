using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyNews.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public int? NewsId { get; set; }
        public News News; 
    }
}