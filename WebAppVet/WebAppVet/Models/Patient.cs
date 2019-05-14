using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppVet.Interfaces;

namespace WebAppVet.Models
{
    public class Patient : IEntity
    {
        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public Client Ownwe { get; private set; }

    }
}