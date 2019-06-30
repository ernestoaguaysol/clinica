namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAppVet.Models;
    using WebAppVet.SharedKernel;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppVet.Data.ClinicaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAppVet.Data.ClinicaDbContext context)
        {
            context.Species.AddOrUpdate(
                s => s.Id,
               new Species { Id = 1, Name = "Perro" },
               new Species { Id = 2, Name = "Gato" }
             );

            context.Clients.AddOrUpdate(
                c => c.Id,
               new Client { Id = 1, Name = "Carlos", Surname = "Perez", TypeDocument = 0, Document = "33123887", Email = "email001@gmail.com" },
               new Client { Id = 2, Name = "Pedro", Surname = "Perez", TypeDocument = 0, Document = "42123887", Email = "email002@gmail.com" }
             );

            context.Patients.AddOrUpdate(
                p => p.Id,
               new Patient { Id = 1, Name = "Loqui", SpeciesId = 1, Gender = Gender.Female, ClientId = 1, Birthdate = new DateTime(2014, 12, 25) },
               new Patient { Id = 2, Name = "Sam", SpeciesId = 1, Gender = Gender.Male, ClientId = 2, Birthdate = new DateTime(2012, 03, 12) },
               new Patient { Id = 3, Name = "Golum", SpeciesId = 1, Gender = Gender.Male, ClientId = 2, Birthdate = new DateTime(2012, 04, 12) }
             );

            context.Doctors.AddOrUpdate(
               d => d.Id,
               new Doctor { Id = 1, DoctorType = DoctorType.Veterinarian , Name = "Alberto", Surname = "Lisboa", Email = "doc001@gmail.com" },
               new Doctor { Id = 2, DoctorType = DoctorType.Surgeon , Name = "Lautaro", Surname = "Almiron", Email = "doc001@gmail.com" },
               new Doctor { Id = 3, DoctorType = DoctorType.Assistant , Name = "Fiorela", Surname = "Quiroz", Email = "doc001@gmail.com" }
             );

            context.Rooms.AddOrUpdate(
               r => r.Id,
               new Room { Id = 1, RoomType = RoomType.Lab , Name = "A", Location = "pb" },
               new Room { Id = 2, RoomType = RoomType.OfficeRoom, Name = "B", Location = "pb" },
               new Room { Id = 3, RoomType = RoomType.OfficeRoom, Name = "C", Location = "pb" },
               new Room { Id = 4, RoomType = RoomType.OfficeRoom, Name = "A", Location = "pb" },
               new Room { Id = 5, RoomType = RoomType.OperationRoom, Name = "B", Location = "pb" },
               new Room { Id = 6, RoomType = RoomType.OperationRoom, Name = "Lab General", Location = "pb" }
             );

            context.Products.AddOrUpdate(
                p => p.Id,
                new Product { Id = 1, Name = "Jeringa", Price = 10.00, Stock = 10},
                new Product { Id = 2, Name = "Purgante para perro", Price = 50.00, Stock = 40},
                new Product { Id = 3, Name = "Purgante para gato", Price = 60.00, Stock = 50},
                new Product { Id = 4, Name = "Collar para perro", Price = 100.00, Stock = 10},
                new Product { Id = 5, Name = "Correa para perro", Price = 100.00, Stock = 10},
                new Product { Id = 6, Name = "Vitaminas", Price = 90.00, Stock = 100 }
                );

            context.Providers.AddOrUpdate(
                p => p.Id,
                new Provider { Id = 1, Name = "Juan", Surname = "Palavechino", Email = "provider1@gmail.com", Phone = "1122334451"},
                new Provider { Id = 2, Name = "Juan", Surname = "Kilosa", Email = "provider2@gmail.com", Phone = "1122334452"},
                new Provider { Id = 3, Name = "Lorena", Surname = "Galeano", Email = "provider3@gmail.com", Phone = "1122334453"},
                new Provider { Id = 4, Name = "Juana", Surname = "Fenosa", Email = "provider4@gmail.com", Phone = "1122334454"},
                new Provider { Id = 5, Name = "Andres", Surname = "Sandobal", Email = "provider5@gmail.com", Phone = "1122334455"},
                new Provider { Id = 6, Name = "Karina", Surname = "Vales", Email = "provider6@gmail.com", Phone = "1122334456"}
                );

        }
    }
}
