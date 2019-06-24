using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class SaleDetail : IEntity
    {
        public SaleDetail()
        {
        }

        public int Id { get; set; }
        public int Quantity { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public virtual double TotalPrice()
        {
            return Product.Price * Quantity;
        }
    }

    [MetadataType(typeof(SaleDetailMetadata))]
    public partial class SaleDetail
    {
        public class SaleDetailMetadata
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public int Quantity { get; set; }
            [Required]
            public int SaleId { get; set; }
            [Required]
            public int ProductId { get; set; }
        }
    }
}