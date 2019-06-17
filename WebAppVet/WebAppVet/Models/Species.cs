using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public partial class Species : IEntity
    {
        public Species()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Patient> Patients { get; private set; }
    }

    [MetadataType(typeof(SpeciesMetadata))]
    public partial class Species
    {
        public class SpeciesMetadata
        {
            [Key]
            public int Id { get; set; }
            [Required]
            [StringLength(50)]
            public string Name { get; set; }
        }
    }
}