using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class ServiceType : IEntity
    {
        public ServiceType()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [MetadataType(typeof(ServiceTypeMetadata))]
    public partial class ServiceType
    {
        public class ServiceTypeMetadata
        {
            [Key]
            public int Id { get; set; }
            [StringLength(50)]
            [Required]
            public string Name { get; set; }
        }

    }
}