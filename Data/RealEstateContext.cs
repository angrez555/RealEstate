using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RealEstate.Models;

namespace RealEstate.Data
{
    public class RealEstateContext : DbContext
    {
        public RealEstateContext (DbContextOptions<RealEstateContext> options)
            : base(options)
        {
        }

        public DbSet<RealEstate.Models.Customer> Customer { get; set; }

        public DbSet<RealEstate.Models.Dealer> Dealer { get; set; }

        public DbSet<RealEstate.Models.Property> Property { get; set; }

        public DbSet<RealEstate.Models.Property_Aucation> Property_Aucation { get; set; }
    }
}
