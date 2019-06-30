using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppVet.Models;

namespace WebAppVet.Data
{
    public class ClinicaDbContext : DbContext
    {
        public ClinicaDbContext() :base("ClinicaDbContext")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Room> Rooms{ get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SupplyDetail> SupplyDetails { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Buy> Buys { get; set; }
        public DbSet<BuyDetail> BuyDetails { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<CommercialInformation> CommercialInformations { get; set; }
        public DbSet<Billing> Billings { get; set; }
        
    }
}