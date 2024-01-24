using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogWebAPI.Models;

namespace BlogWebAPI.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext (DbContextOptions<BlogDbContext> options)
            : base(options)
        {
        }

        public DbSet<BlogWebAPI.Models.AdminInfo> AdminInfo { get; set; } = default!;

        public DbSet<BlogWebAPI.Models.BlogInfo>? BlogInfo { get; set; }

        public DbSet<BlogWebAPI.Models.EmpInfo>? EmpInfo { get; set; }
    }
}
