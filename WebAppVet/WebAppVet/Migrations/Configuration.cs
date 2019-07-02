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
               new Client { Id = 1, Code = 1,Name = "Carlos", Surname = "Perez", TypeDocument = TypeDocument.DNI, DocumentNumber = "33123887", Email = "email001@gmail.com" },
               new Client { Id = 2, Code = 2,Name = "Carlos", Surname = "Zalazar", TypeDocument = TypeDocument.DNI, DocumentNumber = "33243887", Email = "email002@gmail.com" },
               new Client { Id = 3, Code = 3,Name = "Kevin", Surname = "Zacarias", TypeDocument = TypeDocument.DNI, DocumentNumber = "33563887", Email = "email003@gmail.com" },
               new Client { Id = 4, Code = 4,Name = "Barbara", Surname = "Portillo", TypeDocument = TypeDocument.DNI, DocumentNumber = "34123887", Email = "email004@gmail.com" },
               new Client { Id = 5, Code = 5,Name = "Hugo", Surname = "Gerez", TypeDocument = TypeDocument.DNI, DocumentNumber = "34523887", Email = "email005@gmail.com" },
               new Client { Id = 6, Code = 6,Name = "Fiorella", Surname = "Aquino", TypeDocument = TypeDocument.DNI, DocumentNumber = "33563887", Email = "email006@gmail.com" },
               new Client { Id = 7, Code = 7,Name = "Carla", Surname = "Killia", TypeDocument = TypeDocument.DNI, DocumentNumber = "33123677", Email = "email007@gmail.com" },
               new Client { Id = 8, Code = 8,Name = "Patricia", Surname = "Fantino", TypeDocument = TypeDocument.DNI, DocumentNumber = "33893887", Email = "email008@gmail.com" },
               new Client { Id = 9, Code = 9,Name = "Pedro", Surname = "Hidalgo", TypeDocument = TypeDocument.DNI, DocumentNumber = "42122587", Email = "email009@gmail.com" }
             );

            context.Patients.AddOrUpdate(
                p => p.Id,
               new Patient { Id = 1, Name = "Loqui", SpeciesId = 1, Gender = Gender.Female, ClientId = 1, Birthdate = new DateTime(2014, 12, 25) },
               new Patient { Id = 2, Name = "Sam", SpeciesId = 1, Gender = Gender.Male, ClientId = 2, Birthdate = new DateTime(2013, 03, 11) },
               new Patient { Id = 3, Name = "Katara", SpeciesId = 1, Gender = Gender.Female, ClientId = 3, Birthdate = new DateTime(2014, 04, 22) },
               new Patient { Id = 4, Name = "Pepe", SpeciesId = 1, Gender = Gender.Male, ClientId = 4, Birthdate = new DateTime(2012, 05, 12) },
               new Patient { Id = 5, Name = "Piton", SpeciesId = 1, Gender = Gender.Male, ClientId = 5, Birthdate = new DateTime(2013, 06, 13) },
               new Patient { Id = 6, Name = "Chuaka", SpeciesId = 1, Gender = Gender.Male, ClientId = 6, Birthdate = new DateTime(2014, 07, 14) },
               new Patient { Id = 7, Name = "Terri", SpeciesId = 1, Gender = Gender.Male, ClientId = 7, Birthdate = new DateTime(2015, 08, 15) },
               new Patient { Id = 8, Name = "Golum", SpeciesId = 1, Gender = Gender.Male, ClientId = 2, Birthdate = new DateTime(2002, 04, 12) },
               new Patient { Id = 9, Name = "Golum", SpeciesId = 2, Gender = Gender.Male, ClientId = 3, Birthdate = new DateTime(2002, 04, 12) }
             );

            context.Doctors.AddOrUpdate(
               d => d.Id,
               new Doctor { Id = 1, DoctorType = DoctorType.Veterinarian , Name = "Alberto", Surname = "Lisboa", Email = "doc001@gmail.com" },
               new Doctor { Id = 2, DoctorType = DoctorType.Surgeon , Name = "Lautaro", Surname = "Almiron", Email = "doc001@gmail.com" },
               new Doctor { Id = 3, DoctorType = DoctorType.Assistant , Name = "Fiorela", Surname = "Quiroz", Email = "doc001@gmail.com" }
             );

            context.Rooms.AddOrUpdate(
               r => r.Id,
               new Room { Id = 1, RoomType = RoomType.OfficeRoom, Name = "A", Location = "pb" },
               new Room { Id = 2, RoomType = RoomType.OfficeRoom, Name = "B", Location = "pb" },
               new Room { Id = 3, RoomType = RoomType.OfficeRoom, Name = "C", Location = "pb" },
               new Room { Id = 4, RoomType = RoomType.OperationRoom, Name = "A", Location = "pb" },
               new Room { Id = 5, RoomType = RoomType.OperationRoom, Name = "B", Location = "pb" },
               new Room { Id = 6, RoomType = RoomType.Lab, Name = "Lab General", Location = "pb" }
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

            context.CommercialInformations.AddOrUpdate(
                ci => ci.Id,
                new CommercialInformation { Id = 1, Address = "Rivadavia 1232", City = "San Miguel", Country = "Argentina", Cuit = "20-232323-2", Email = "veterinaria@gmail.com", PostalCode = "1744"}
                );

            context.Appointments.AddOrUpdate(
                a => a.Id,
                new Appointment { Id = 1, Date = new DateTime(2019,6,20,20,00,00), DoctorId = 1, PatientId = 1, RoomId = 1, ServiceType = ServiceType.MedicalConsultation, State = AppointmentState.Attended},
                new Appointment { Id = 2, Date = new DateTime(2019,7,20,20,00,00), DoctorId = 1, PatientId = 2, RoomId = 1, ServiceType = ServiceType.MedicalConsultation, State = AppointmentState.Canceled},
                new Appointment { Id = 3, Date = new DateTime(2019,6,30,20,00,00), DoctorId = 1, PatientId = 3, RoomId = 2, ServiceType = ServiceType.MedicalConsultation, State = AppointmentState.Canceled},
                new Appointment { Id = 4, Date = new DateTime(2019,7,20,20,00,00), DoctorId = 1, PatientId = 4, RoomId = 2, ServiceType = ServiceType.MedicalConsultation, State = AppointmentState.Active},
                new Appointment { Id = 5, Date = new DateTime(2019,7,21,20,00,00), DoctorId = 1, PatientId = 5, RoomId = 3, ServiceType = ServiceType.MedicalConsultation, State = AppointmentState.Active},
                new Appointment { Id = 6, Date = new DateTime(2019,7,22,20,00,00), DoctorId = 2, PatientId = 6, RoomId = 4, ServiceType = ServiceType.Surgery, State = AppointmentState.Active},
                new Appointment { Id = 7, Date = new DateTime(2019,7,23,20,00,00), DoctorId = 2, PatientId = 7, RoomId = 4, ServiceType = ServiceType.Surgery, State = AppointmentState.Active},
                new Appointment { Id = 8, Date = new DateTime(2019,7,24,20,00,00), DoctorId = 2, PatientId = 8, RoomId = 5, ServiceType = ServiceType.Surgery, State = AppointmentState.Active},
                new Appointment { Id = 9, Date = new DateTime(2019,7,25,20,00,00), DoctorId = 2, PatientId = 9, RoomId = 5, ServiceType = ServiceType.Surgery, State = AppointmentState.Active}
                );

            context.Billings.AddOrUpdate(
                b => b.Id,
                new Billing { Id = 1, AppointmentId = 1, BillingType = BillingType.A, Code = 1234, CommercialInformationId = 1, Date = new DateTime(2019, 6, 20, 20, 30, 00), Iva = 0.21, Subtotal = 200, Total = 221}
                );
        }
    }
}
