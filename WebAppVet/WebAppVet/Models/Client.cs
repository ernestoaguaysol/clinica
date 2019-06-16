using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;
using WebAppVet.SharedKernel;

namespace WebAppVet.Models
{
    public partial class Client : IEntity
    {
        public Client()
        {
            Patients = new List<Patient>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Document { get; set; }
        public TypeDocument TypeDocument { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }

        public IList<Patient> Patients { get; private set; }

        
    }

    [MetadataType(typeof(ClientMetadata))]
    public partial class Client
    {
        public class ClientMetadata
        {
            [Key]
            public int Id { get; set; }
            [StringLength(50)]
            [Required]
            public string Name { get; set; }
            [StringLength(50)]
            [Required]
            public string Surname { get; set; }
            [StringLength(50)]
            [Required]
            public string Document { get; set; }
            [Required]
            public TypeDocument TypeDocument { get; set; }
            [StringLength(50)]
            [EmailAddress]
            [Required]
            public string Email { get; set; }
            [StringLength(50)]
            [Phone]
            public string Phone { get; set; }
            [StringLength(50)]
            [Phone]
            public string MobilePhone { get; set; }
            [StringLength(50)]
            public string Address { get; set; }
            [StringLength(50)]
            public string UserName { get; set; }
        }
    }
}