using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DotNetCorePractice.Models
{
    public class DotNetCorePracticeContext : DbContext
    {
        public DotNetCorePracticeContext (DbContextOptions<DotNetCorePracticeContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetCorePractice.Models.Movie> Movie { get; set; }
    }
}
