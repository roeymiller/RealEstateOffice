using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace RealEstateOffice.Models
{
    public class Broker
    {

        [Required]
        [DisplayName("BrokerID")]
        public int BrokerID { get; set; }

        [Required]
        [DisplayName("Name")]
        public int Name { get; set; }

        [Required]
        [DisplayName("Deals")]
        public String Deals { get; set; }

    }
}