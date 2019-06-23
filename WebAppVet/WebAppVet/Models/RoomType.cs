using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class RoomType : IEntity
    {
        public RoomType()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Room> Rooms { get; private set; }
    }

    [MetadataType(typeof(RoomTypeMetadata))]
    public partial class RoomType
    {
        public class RoomTypeMetadata
        {
            [Key]
            public int Id { get; set; }
            [StringLength(50)]
            [Required]
            public string Name { get; set; }
        }

    }


}