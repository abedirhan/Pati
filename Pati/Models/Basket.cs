using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pati.Models
{
    public class Basket
    {
        [Key]
        public int IdBasket { get; set; }
        [DisplayName("Quantity")]
        public int Quantity { get; set; }
        [DisplayName("Is Order Placed")]
        public int OrderPlaced { get; set; }
        [DisplayName("Sub Total")]
        public double SubTotal { get; set; }
        [DisplayName("Total")]
        public double Total { get; set; }
        [DisplayName("Tax Number")]
        public string TaxNumber { get; set; }
        [DisplayName("Created Date")]
        public DateTime DateCrated { get; set; }
        [DisplayName("Customer Id")]
        public int IdCustomer { get; set; }
        [DisplayName("Shipment Id")]
        public int IdShipping { get; set; }
    }
}
