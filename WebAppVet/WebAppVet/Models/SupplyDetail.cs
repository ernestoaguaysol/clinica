using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class SupplyDetail : IEntity
    {
        public SupplyDetail()
        {
        }

        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int AppointmentId { get; set; }
        public int Quantity { get; set; }
        public virtual double TotalPrice()
        {
            return Product.Price * Quantity;
        }
    }

    [MetadataType(typeof(SupplyDetailMetadata))]
    public partial class SupplyDetail
    {
        public class SupplyDetailMetadata
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public int ProductId { get; set; }
            [Required]
            public int AppointmentId { get; set; }
            [Required]
            [Range(1, int.MaxValue)]
            public int Quantity { get; set; }
        }
    }
}