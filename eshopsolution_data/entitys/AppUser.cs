using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace eshopsolution_data.entitys
{
    public class AppUser :IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public List<Carts> Carts { get; set; }

        public List<Orders> Orders { get; set; }

        public List<Transactions> Transactions { get; set; }
    }
}
