using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppVet.Models
{
    public partial class Appointment
    {
        public int Id { get; set; }
    }

    [MetadataType(typeof(AppointmentMetadata))]
    public partial class Appointment
    {
        public class AppointmentMetadata
        {
            [Key]
            public int Id { get; set; }
        }
    }
}