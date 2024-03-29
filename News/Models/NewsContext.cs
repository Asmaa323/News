﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News.Models
{
    public class NewsContext:DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options)
         : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Teammember> Teammembers { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }


    }
}
