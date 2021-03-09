using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Models
{ 
    //This class is holding details of property dealer who sold properties to customers. Class holds the name of dealer, address, Email And phone number.
    public class Dealer
    {

        public int Id { get; set; }

        [Required]
        public string Dealer_Name { get; set; }


        public string Dealer_Address { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        public string Email { get; set; }
    }
}

