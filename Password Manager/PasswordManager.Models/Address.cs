using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace PasswordManager.Models
{
    public class Address
    {
        public int addressId { get; set; }

        public string country { get; set; }

        public string organization { get; set; }

        public string streetAddress { get; set; }
    }
}
