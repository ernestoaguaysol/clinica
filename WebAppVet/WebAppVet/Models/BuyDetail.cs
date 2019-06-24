using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class BuyDetail : IEntity
    {
        public BuyDetail()
        {
        }

        public int Id { get; set; }
        public int Quantity { get; set; }
        public int BuyId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public virtual double TotalPrice()
        {
            return Product.Price * Quantity;
        }
    }

    [MetadataType(typeof(BuyDetailMetadata))]
    public partial class BuyDetail
    {
        public class BuyDetailMetadata
        {
            [Key]
            public int Id { get; set; }
            [Required]
            [Range(1, int.MaxValue)]
            public int Quantity { get; set; }
            [Required]
            public int BuyId { get; set; }
            [Required]
            public int ProductId { get; set; }

        }
    }
}