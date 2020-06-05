using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealEstateOffice.Models
{
    public class Property
    {
        [Required]
        public int PropertyID { get; set; }

        [Required]
        [DisplayName("Adress")]
        public string Adress { get; set; }

        [Required]
        [DisplayName("NumOfRooms")]
        public string NumOfRooms { get; set; }

        [Required]
        [DisplayName("Price")]
        public int Price { get; set; }

        [Required]
        [DisplayName("Type")]
        public string Type { get; set; }

        [Required]
        [DisplayName("Elevator")]
        public Boolean Elevator { get; set; }

        [Required]
        [DisplayName("Balcony")]
        public Boolean Balcony { get; set; }

        [Required]
        [DisplayName("Parking")]
        public Boolean Parking { get; set; }

        [Required]
        [DisplayName("Category")]
        public string Category { get; set; }


        [Required]
        [DisplayName("SQfeet")]
        public int SQfeet { get; set; }

        [Required]
        [DisplayName("About")]
        public string About { get; set; }

    }
}

