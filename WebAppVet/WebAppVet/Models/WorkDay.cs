using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class WorkDay : IEntity
    {
        public WorkDay()
        {
        }

        public int Id { get; set; }
        public DayOfWeek Day { get; set; }
        public int DoctorId { get; set; }
    }

    [MetadataType(typeof(WorkDayMetadata))]
    public partial class WorkDay
    {
        public class WorkDayMetadata
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public DayOfWeek Day { get; set; }
            [Required]
            public int DoctorId { get; set; }
        }

    }
}