using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class Sale : IEntity
    {
        public Sale()
        {
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ClientId { get; set; }

    }

    [MetadataType(typeof(SaleMetadata))]
    public partial class Sale
    {
        public class SaleMetadata
        {
            [Key]
            public int Id { get; set; }
            [Required]
            [Column(TypeName = "datetime2")]
            public DateTime Date { get; set; }
            // se puede hacer una compra sin cliente por eso no es [Required]
            public int ClientId { get; set; }

        }
    }
}