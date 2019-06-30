using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;
using WebAppVet.SharedKernel;

namespace WebAppVet.Models
{
    public partial class Room : IEntity
    {
        public Room()
        {
        }

        public int Id { get; set; }
        public RoomType RoomType { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public IList<Appointment> Appointments { get; private set; }

    }

    [MetadataType(typeof(RoomMetadata))]
    public partial class Room
    {
        public class RoomMetadata
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public RoomType RoomType { get; set; }
            [StringLength(50)]
            [Required]
            public string Name { get; set; }
            [StringLength(50)]
            public string Location { get; set; }
        }
    }


}