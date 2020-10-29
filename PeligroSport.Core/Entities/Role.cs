using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeligroSport.Core.Entities
{
   public class Role : IdentityRole
    {
        public Role(string name, string description) : base(name)
        {
            Name = name;
            Description = description;
        }

        public Role() : base() { }

        public string Description { get; set; }
    }
}
