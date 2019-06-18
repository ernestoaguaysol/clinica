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
               new Client { Id = 1, Name = "Carlos", Surname = "Perez", TypeDocument = 0, Document = "33123887" , Email = "email001@gmail.com"},
               new Client { Id = 2, Name = "Pedro", Surname = "Perez", TypeDocument = 0, Document = "42123887" , Email = "email002@gmail.com"}
             );

            context.Patients.AddOrUpdate(
                p => p.Id,
               new Patient { Id = 1, Name = "Loqui", SpeciesId = 1, Gender = Gender.Female, ClientId = 1, Birthdate = new DateTime(2014,12,25) },
               new Patient { Id = 2, Name = "Sam", SpeciesId = 1, Gender = Gender.Male, ClientId = 2 , Birthdate = new DateTime(2012,03,12) },
               new Patient { Id = 3, Name = "Golum", SpeciesId = 1, Gender = Gender.Male, ClientId = 2 , Birthdate = new DateTime(2012,04,12) }
             );

            context.Doctors.AddOrUpdate(
               d => d.Id,
               new Doctor { Id = 0, Name = "Alberto", Surname = "Lisboa", Email = "doc001@gmail.com" },
               new Doctor { Id = 1, Name = "Lautaro", Surname = "Almiron", Email = "doc001@gmail.com" },
               new Doctor { Id = 2, Name = "Fiorela", Surname = "Quiroz", Email = "doc001@gmail.com" }
             );

            context.Rooms.AddOrUpdate(
               r => r.Id,
               new Room { Id = 1, Name = "sala 1", Location = "pb" },
               new Room { Id = 2, Name = "sala 2", Location = "pb" }
             );
        }
    }
}
