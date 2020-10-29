using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PeligroSport.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeligroSport.Core.Context
{
   public class PeligroSportDBContext : IdentityDbContext<Usuarios, Role, string>
    {

        public PeligroSportDBContext()
        {
        }

        public PeligroSportDBContext(DbContextOptions<PeligroSportDBContext> options) : base (options)
        {
        }

        public virtual DbSet<Usuarios> User { get; set; }

        public virtual DbSet<Role> Role { get; set; }

        public virtual DbSet<Address> Address { get; set; }

        public virtual DbSet<BillingAddress> BillingAddress { get; set; }

        public virtual DbSet<ShippingAddress> ShippingAddresses { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
    }
}
