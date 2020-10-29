using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeligroSport.Areas.Identity.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Es necesario su nombre de usuario")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Es necesaria la contraseña")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public bool Estado { get; set; }
    }
}
