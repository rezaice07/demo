using DvdRental.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdRental.Service
{
    public class DvdRentalDbContext : DbContext
    {
        public DvdRentalDbContext() : base("DvdRentalDbContext")
        {

        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}
