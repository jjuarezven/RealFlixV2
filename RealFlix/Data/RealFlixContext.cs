using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RealFlix.Models;

    public class RealFlixContext : DbContext
    {
        public RealFlixContext (DbContextOptions<RealFlixContext> options)
            : base(options)
        {
        }

        public DbSet<RealFlix.Models.Show> Show { get; set; }
    }
