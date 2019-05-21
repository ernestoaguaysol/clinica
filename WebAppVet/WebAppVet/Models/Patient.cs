﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;
using WebAppVet.SharedKernel;

namespace WebAppVet.Models
{
    public partial class Patient : IEntity
    {
        public Patient()
        {
        }

        public int Id { get; set; }
        public Client Owner { get; private set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }

        
    }

    public partial class Patient
    {
        [MetadataType(typeof(PatientMetadata))]
        public class PatientMetadata
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public Client Owner { get; private set; }
            [Required]
            public int ClientId { get; set; }
            [StringLength(50)]
            [Required]
            public string Name { get; set; }
            [Required]
            public Gender Gender { get; set; }
        }
    }
}