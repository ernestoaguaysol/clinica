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
        public IList<SaleDetail> SaleDetails { get; set; }
        public virtual double TotalPrice()
        {
            return SaleDetails.Sum(tp => tp.TotalPrice());
        }
        public Billing Billing { get; set; }

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
            public int ClientId { get; set; }

        }
    }
}