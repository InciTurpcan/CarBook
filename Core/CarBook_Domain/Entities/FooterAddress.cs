using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Domain.Entities
{
    public class FooterAddress
    {
        public int FooterAddressID { get; set; }
        public string Description { get;}
        public string Address { get; }
        public string Phone { get; }
        public string Email { get; }
    }
}
