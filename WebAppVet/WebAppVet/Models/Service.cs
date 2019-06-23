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
        public string Name { get; set; }
    }

    [MetadataType(typeof(ServiceMetadata))]
    public partial class Service
    {

        class ServiceMetadata
        {
            [Key]
            public int Id { get; set; }
        }
    }
}