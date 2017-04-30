using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyNews.Models
{
    public class NewsContext : DbContext
    {
        public NewsContext() : base("name = NewsContext")
        {

        }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
    }
    
}