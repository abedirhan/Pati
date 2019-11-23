using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pati.Models
{
    public class Customer
    {
        [Key] public int IdCustomer { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Address")]
        public string Address { get; set; }
        [DisplayName("City")]
        public string City { get; set; }
        [DisplayName("State")]
        public string State { get; set; }
        [DisplayName("Zip Code")]
        public string ZipCode { get; set; }
        [DisplayName("Phone")]
        public string Phone { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("User Name")]
        public string UserName { get; set; }
        [DisplayName("User Password")]
        public string UserPassword { get; set; }
        [DisplayName("Date Entered")]
        public DateTime DateEntered { get; set; }
        [DisplayName("Country")]
        public string Country { get; set; }



    }
}
