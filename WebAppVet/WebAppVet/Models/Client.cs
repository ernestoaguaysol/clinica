using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public class Client : IEntity
    {
        public Client()
        {
            
        }

        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string FullName { get; set; }

        public string Email { get; set; }
    }
}