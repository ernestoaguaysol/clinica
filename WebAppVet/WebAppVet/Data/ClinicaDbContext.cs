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
        public DbSet<Service> Services { get; set; }
        public DbSet<RoomType> RoomsTypes { get; set; }
        public DbSet<Room> Rooms{ get; set; }


    }
}