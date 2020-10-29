using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PeligroSportCore.Entities
{
   public class Users
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

    }
}
