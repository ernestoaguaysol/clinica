using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class Provider : IEntity
    {
        public Provider()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public IList<Buy> Buys { get; private set; }
    }

    [MetadataType(typeof(ProviderMetadata))]
    public partial class Provider
    {
        public class ProviderMetadata
        {
            [Key]
            public int Id { get; set; }
            [Required]
            [StringLength(50)]
            public string Name { get; set; }
            [Required]
            [StringLength(50)]
            public string Surname { get; set; }
            [Required]
            [StringLength(50)]
            [EmailAddress]
            public string Email { get; set; }
            [Required]
            [StringLength(50)]
            [Phone]
            public string Phone { get; set; }
            [StringLength(100)]
            public string Address { get; set; }
        }
    }
}