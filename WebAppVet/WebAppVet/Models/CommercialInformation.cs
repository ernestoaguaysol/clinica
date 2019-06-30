using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class CommercialInformation : IEntity
    {
        public CommercialInformation()
        {
        }
        public int Id { get; set; }
        public string Cuit { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public IList<Billing> Billings { get; set; }
    }

    [MetadataType(typeof(CommercialInformationMetadata))]
    public partial class CommercialInformation
    {
        public class CommercialInformationMetadata
        {
            [Key]
            public int Id { get; set; }
            [StringLength(50)]
            public string Cuit { get; set; }
            [StringLength(100)]
            public string Address { get; set; }
            [StringLength(100)]
            public string PostalCode { get; set; }
            [StringLength(100)]
            public string City { get; set; }
            [StringLength(100)]
            public string Country { get; set; }
            [StringLength(50)]
            [EmailAddress]
            public string Email { get; set; }
        }
    }
}