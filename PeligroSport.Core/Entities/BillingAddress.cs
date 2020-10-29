using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PeligroSport.Core.Entities
{
   public class BillingAddress
    {
        public int BillingAddressId { get; set; }

        public string AddresLineOne { get; set; }
        public string AddresLineTwo { get; set; }

        public string City { get; set; }
        public string State { get; set; }


        public string ZipCode { get; set; }

        [MaxLength(50)]
        public string CreatorId { get; set; }

        [MaxLength(50)]
        public string ModifierId { get; set; }

        public int CountryId { get; set; }

        //[ForeignKey("ModifierId")]
        //public virtual Users Modifier { get; set; } 
        
        
        //[ForeignKey("CreatorId")]
        //public virtual Users Creator { get; set; }



        [ForeignKey("CountryId")]
        public virtual Countries Country { get; set; }
    }
}
