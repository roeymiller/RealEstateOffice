using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealEstateOffice.Models
{
    public class Deal
    {

        [Required]
        [DisplayName("DealID")]
        public int DealID { get; set; }

        [Required]
        [DisplayName("PropertyID")]
        public int PropertyID { get; set; }

        [Required]
        [DisplayName("CustomerID")]
        public int CustomerID { get; set; }

        [Required]
        [DisplayName("BrokerID")]
        public int BrokerID { get; set; }

        [Required]
        [DisplayName("Price")]
        public int Price { get; set; }

        [Required]
        [DisplayName("Commition")]
        public int Commition { get; set; }

        [Required]
        [DisplayName("Categorty")]
        public int Categorty { get; set; }

    }
}