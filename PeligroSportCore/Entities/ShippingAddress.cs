using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PeligroSportCore.Entities
{
   public class ShippingAddress
    {
        public int ShippingAddressId { get; set; }

        public string AddresLineOne { get; set; }
        public string AddresLineTwo { get; set; }

        public string City { get; set; }
        public string State { get; set; }

        public int CountryId { get; set; }

        public  string ZipCode { get; set; }

        [MaxLength(50)]
        public string CreatorId { get; set; }

        [MaxLength(50)]
        public string ModifierId { get; set; }
    }
}
