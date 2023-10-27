using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCIntro.Models;
using MVCIntro.Models.ViewModels;

namespace MVCIntro.Data
{
    public class MVCIntroContext : DbContext
    {
        public MVCIntroContext (DbContextOptions<MVCIntroContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee => Set<Employee>();


       // public DbSet<Car> Car { get; set; } = default!;
    }
}
