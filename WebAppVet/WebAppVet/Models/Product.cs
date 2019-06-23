using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class Product : IEntity
    {
        public Product()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public IList<SupplyDetail> SupplyDetails { get; private set; }
    }

    [MetadataType(typeof(ProductMetadata))]
    public partial class Product
    {
        public class ProductMetadata
        {
            [Key]
            public int Id { get; set; }
            [StringLength(100)]
            [Required]
            [Index(IsUnique = true)]
            public string Name { get; set; }
            [StringLength(250)]
            public string Description { get; set; }
            [Required]
            public double Price { get; set; }
            [Required]
            public int Stock { get; set; }

        }
    }
}