using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class Buy : IEntity
    {
        public Buy()
        {
        }

        public int Id { get; set; }
        public int ProviderId { get; set; }
        public DateTime Date { get; set; }
        public IList<BuyDetail> BuyDetails { get; set; }
    }

    [MetadataType(typeof(BuyMetadata))]
    public partial class Buy
    {
        public class BuyMetadata
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public int ProviderId { get; set; }
            [Required]
            [Column(TypeName = "datetime2")]
            public DateTime Date { get; set; }
        }
    }
}