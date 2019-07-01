using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;
using WebAppVet.SharedKernel;

namespace WebAppVet.Models
{
    public partial class Appointment : IEntity
    {
        public Appointment()
        {
        }

        public int Id { get; set; }
        public ServiceType ServiceType { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int RoomId { get; set; }
        public DateTime Date { get; set; }
        public AppointmentState State { get; set; }
        public string Description { get; set; }
        public Billing Billing { get; set; }
        public IList<SupplyDetail> SupplyDetails { get; set; }
    }

    [MetadataType(typeof(AppointmentMetadata))]
    public partial class Appointment
    {
        public class AppointmentMetadata
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public ServiceType ServiceType { get; set; }
            [Index("IX_Appointment_Keywords", IsUnique = true, Order = 1)]
            [Required]
            public int PatientId { get; set; }
            [Index("IX_Appointment_Keywords", IsUnique = true, Order = 2)]
            [Required]
            public int DoctorId { get; set; }
            [Index("IX_Appointment_Keywords", IsUnique = true, Order = 3)]
            [Required]
            public int RoomId { get; set; }
            [Index("IX_Appointment_Keywords", IsUnique = true, Order = 4)]
            [Column(TypeName = "datetime2")]
            [Required]
            public DateTime Date { get; set; }
            [Required]
            public AppointmentState State { get; set; }
            [StringLength(250)]
            public string Description { get; set; }

        }
    }
}