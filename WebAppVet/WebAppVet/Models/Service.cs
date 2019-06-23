using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class Service : IEntity
    {
        public Service()
        {
        }
        public int Id { get; set; }
        public int ServiceTypeId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public IList<SupplyDetail> SupplyDetails { get; private set; }
    }

    [MetadataType(typeof(ServiceMetadata))]
    public partial class Service
    {

        class ServiceMetadata
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public int ServiceTypeId { get; set; }
            [Required]
            public int PatientId { get; set; }
            [Required]
            public int DoctorId { get; set; }
            [Required]
            public double Price { get; set; }
            [StringLength(250)]
            public string Description { get; set; }

        }
    }
}