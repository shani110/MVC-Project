using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace PasswordManager.Models
{
    public class Payment
    {
        public int paymentId { get; set; }

        public DateTime expirationDate { get; set; }

        public string name { get; set; }

    }
}
