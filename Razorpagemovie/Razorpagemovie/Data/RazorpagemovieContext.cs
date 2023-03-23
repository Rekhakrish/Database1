using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Razorpagemovie.Models;

namespace Razorpagemovie.Data
{
    public class RazorpagemovieContext : DbContext
    {
        public RazorpagemovieContext (DbContextOptions<RazorpagemovieContext> options)
            : base(options)
        {
        }

        public DbSet<Razorpagemovie.Models.Movie> Movie { get; set; } = default!;
    }
}
