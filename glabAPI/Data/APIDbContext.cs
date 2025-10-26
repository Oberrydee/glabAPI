using glabAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace glabAPI.Data
{
    public class APIDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options){}
    }
}
