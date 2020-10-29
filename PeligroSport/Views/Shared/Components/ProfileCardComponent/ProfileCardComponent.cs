using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PeligroSport.Core.Entities;
using PeligroSport.Core.Interfaces;
using PeligroSport.Core.Tools;
using PeligroSport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeligroSport.Views.Shared.Components.ProfileCardComponent
{
    public class ProfileCardComponent : ViewComponent
    {

        private readonly UserManager<Usuarios> _userManager;
        private readonly IUsuarios _usuarios;

        public ProfileCardComponent(IUsuarios usuarios)
        {
            _usuarios = usuarios;
        }

        public IViewComponentResult Invoke()
        {
            var user = this.HttpContext.User;

            var userName = user.Identity.Name;    
                
            var userData =   _usuarios.GetByUserName(userName);

            var model = CopyProperties.Convert<Usuarios, UsuariosModel>(userData);


            return View("ProfileCard", model);
        }
    }
}
