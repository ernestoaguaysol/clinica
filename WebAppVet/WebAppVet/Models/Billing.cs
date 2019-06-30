using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;
using WebAppVet.SharedKernel;

namespace WebAppVet.Models
{
    public partial class Billing : IEntity
    {
        public Billing()
        {
        }
        public int Id { get; set; }
        public int CommercialInformationId { get; set; }
        public int SaleId { get; set; }
        public int AppointmentId { get; set; }
        public int Code { get; set; }
        public DateTime Date { get; set; }
        public BillingType BillingType { get; set; }
        public double Subtotal { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
    }

    [MetadataType(typeof(BillingMetadata))]
    public partial class Billing
    {
        public class BillingMetadata
        {
            [Key]
            public int Id { get; set; }
            public int CommercialInformationId { get; set; }
            public int SaleId { get; set; }
            public int AppointmentId { get; set; }
            [Index(IsUnique = true)]
            [Required]
            public int Code { get; set; }
            [Column(TypeName = "datetime2")]
            [Required]
            public DateTime Date { get; set; }
            [Required]
            public BillingType BillingType { get; set; }
            [Required]
            public double Subtotal { get; set; }
            [Required]
            public double Iva { get; set; }
            [Required]
            public double Total { get; set; }
        }
    }
}