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
    public partial class Doctor : IEntity
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DoctorType DoctorType { get; set; }

        public IList<Appointment> Appointments { get; private set; }
    }

    [MetadataType(typeof(DoctorMetadata))]
    public partial class Doctor
    {
        public class DoctorMetadata
        {
            [Key]
            public int Id { get; set; }
            [Required]
            [Index(IsUnique = true)]
            public int Code { get; set; }
            [StringLength(50)]
            [Required]
            public string Name { get; set; }
            [StringLength(50)]
            [Required]
            public string Surname { get; set; }
            [StringLength(50)]
            [EmailAddress]
            [Required]
            [Index(IsUnique = true)]
            public string Email { get; set; }
            [Required]
            public DoctorType DoctorType { get; set; }

        }
    }
}