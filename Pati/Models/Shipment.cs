using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pati.Models
{
    public class Shipment
    {[Key]
        public int IdShipping { get; set; }
        [DisplayName ("Delivery Status")]
        public string IsDelivered { get; set; }
    }
}
