using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class Doctor : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        
    }

    [MetadataType(typeof(DoctorMetadata))]
    public partial class Doctor
    {
        public class DoctorMetadata
        {
            [Key]
            public int Id { get; set; }
            [StringLength(50)]
            [Required]
            public string Name { get; set; }
            [EmailAddress]
            public string Email { get; set; }
        }
    }
}