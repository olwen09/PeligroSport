using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PeligroSport.Core.Entities
{
   public class Countries
    {
        public int Id { get; set; }


        [MaxLength(4)]
        public string Iso { get; set; }


        [MaxLength(80)]
        public string  Name { get; set; }


        [MaxLength(80)]
        public string  NiceName{ get; set; }


        [MaxLength(4)]
        public string Iso3 { get; set; }


        [MaxLength(6)]
        public string NumCode { get; set; }

        public int  PhoneCode{ get; set; }
    }
}
