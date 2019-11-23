using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;

namespace Pati.Models
{
    public class BasketItem
    {
        [Key]
        public int IdBasketItem { get; set; }
        [DisplayName("Quantity")]
        public int ItemQuantity { get; set; }
        [DisplayName("Product Id")]
        public int IdProduct { get; set; }
        [DisplayName("Basket Id")]
        public int IdBasket { get; set; }

    }
}
