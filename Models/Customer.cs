using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Models
{//This class is holding a detail of customer like their names, Address, email of customers and address.
    public class Customer
    {

        public int Id { get; set; }

        [Required]
        public string Customer_Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }


        public string Address { get; set; }

    }
}
