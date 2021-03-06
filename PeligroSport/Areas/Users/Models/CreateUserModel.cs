﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeligroSport.Areas.Users.Models
{
    public class CreateUserModel
    {

        [Required]
        public string  UserName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }


        [DataType(DataType.Password)]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public string Role { get; set; }

        public int? AddressId { get; set; }
        public int? ShippingAddressId { get; set; }
        public int? BillingAddressId { get; set; }
        public AddressModel AddressModel { get; set; }
        public BillingAddressModel BillingAddressModel { get; set; }
        public ShippingAddressModel ShippingAddressModel  { get; set; }



    }
}
