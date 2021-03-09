using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Models
{
    public class Property_Aucation
    { 
    //The class contains Oction details for property like, Oction ID and Bid price. Also, it contains foriegn key of Property Id,Customer Id, and Dealer ID.
    // This class is linked with Dealer details class, customer dtail class and property detail class.

    public int Id { get; set; }

    [Required]
    public Decimal Bid_Price { get; set; }

    public int PropertyId { get; set; }
    public Property Property { get; set; }

    public int CustomerId { get; set; }

    public Customer Customer { get; set; }

    public int DealerId { get; set; }

    public Dealer Dealer { get; set; }

}
}
