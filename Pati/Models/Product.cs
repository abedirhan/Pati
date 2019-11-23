using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pati.Models
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [DisplayName("Price")]
        public int Price { get; set; }
        [DisplayName("Product Description")]
        public string Description { get; set; }
        [DisplayName("Product Image")]
        public byte[] ProductImage { get; set; }
    }
}
