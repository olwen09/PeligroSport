using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PeligroSport.Core.Entities;
using PeligroSport.Core.Interfaces;
using PeligroSport.Core.Tools;
using PeligroSport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PeligroSport.Views.Shared.AsideMenuComponent
{
    public class AsideMenuComponent  : ViewComponent
    {

        private readonly UserManager<Usuarios> _userManager;
        private readonly IUsuarios _usuarios;

        public AsideMenuComponent(UserManager<Usuarios> userManager, IUsuarios usuarios)
        {
            _userManager = userManager;
            _usuarios = usuarios;
        }

        public IViewComponentResult Invoke()
        {

            var user = this.HttpContext.User;


           
            var userName = user.Identity.Name;

            var userData = _usuarios.GetByUserName(userName);

            var model = CopyProperties.Convert<Usuarios, UsuariosModel>(userData);

            return View("AsideMenu", model);
        }
    }
}
