using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PeligroSport.Core.Entities
{
   public class Usuarios : IdentityUser
    {

        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        public string Role { get; set; }

        public bool Estado { get; set; }

        [MaxLength(50)]
        public string CreatorId { get; set; }

        [MaxLength(50)]
        public string ModifierId { get; set; }


        public int? AddressId { get; set; }
        public int? ShippingAddressId { get; set; }
        public int? BillingAddressId { get; set; }


        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }

        [ForeignKey("ShippingAddressId")]
        public virtual ShippingAddress ShippingAddress { get; set; }


        [ForeignKey("BillingAddressId")]
        public virtual BillingAddress BillingAddress { get; set; }

    }
}
