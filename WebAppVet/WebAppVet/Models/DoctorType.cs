using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class DoctorType : IEntity
    {
        public DoctorType()
        {
        }

        public int Id { get; set; }
        public string Type { get; set; }
    }

    [MetadataType(typeof(DoctorTypeMetadata))]
    public partial class DoctorType
    {
        public class DoctorTypeMetadata
        {
            [Key]
            public int Id { get; set; }
            [StringLength(50)]
            public string Type { get; set; }
        }
    }
}