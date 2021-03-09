using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Models
{ 
    //This class is holding a details of propert like property type for (eg.House, office rent), 
    //Area where property is located, The current price of property and the facilities available in property.
    public class Property
    {

        public int Id { get; set; }

        public string Property_Type { get; set; }
        [Required]

        public string Area { get; set; }
        [Required]

        public decimal Price { get; set; }
        [Required]

        public string Specifications { get; set; }

    }
}
