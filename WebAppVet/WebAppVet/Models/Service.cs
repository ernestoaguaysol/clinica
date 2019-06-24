﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class Service : IEntity
    {
        public Service()
        {
        }
        public int Id { get; set; }
        public int ServiceTypeId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public IList<SupplyDetail> SupplyDetails { get; private set; }
        public virtual double TotalPrice()
        {
            return Price + SupplyDetails.Sum(tp => tp.TotalPrice());
        }
    }

    [MetadataType(typeof(ServiceMetadata))]
    public partial class Service
    {

        class ServiceMetadata
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public int ServiceTypeId { get; set; }
            [Required]
            public int PatientId { get; set; }
            [Required]
            public int DoctorId { get; set; }
            [Required]
            public double Price { get; set; }
            [StringLength(250)]
            public string Description { get; set; }
            [Required]
            [Column(TypeName = "datetime2")]
            public DateTime Date { get; set; }


        }
    }
}