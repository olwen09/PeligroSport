using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PeligroSport.Areas.Users.Models;
using PeligroSport.Core.Interfaces;
using MailKit.Net.Smtp;
using MimeKit;
using Microsoft.AspNetCore.Identity;
using PeligroSport.Core.Entities;
using PeligroSport.Core.Tools;
using System.Security.Claims;
using PeligroSport.Models;

namespace PeligroSport.Areas.Users.Controllers
{

    [Area("Users")]
    public class UserController : Controller
    {

        private readonly ICountries _countries;
        private readonly UserManager<Usuarios> _userManager;
        private readonly RoleManager<Role> _roleManger;
        private readonly IUsuarios _users;

        public UserController(ICountries countries, IUsuarios users, UserManager<Usuarios> userManager,
            RoleManager<Role> roleManger)
        {
            _countries = countries;
            _users = users;
            _userManager = userManager;
            _roleManger = roleManger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Register()
        {
            ViewBag.Countries = new SelectList(_countries.Countries, "Id", "NiceName");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Policy = Constante.UsuariorCanCreate)]
        public async Task<IActionResult> Register(CreateUserModel model)
        {
            if (ModelState.IsValid)
            {
                //MensajesViewModel mensaje = new MensajesViewModel();

                var user = CopyProperties.Convert<CreateUserModel, Usuarios>(model);
                var email = _users.GetAll.FirstOrDefault(x => x.Email.Equals(model.Email));
                user.EmailConfirmed = true;
                model.Password = "Ab@123";
                //ViewData["Prueba"] =  _localizer["Este email ya existe, intenten con otro"];




                try
                {

                    if (model.Password.Length < 6)
                    {
                        //mensaje.Titulo = "La Contraseña debe contener al menos 6 digitos";
                    }

                    else if (email != null)
                    {

                        //mensaje.Titulo = "Este email ya existe, intenten con otro";
                        //ViewData["Prueba"] = _localizer["Clientes"];
                    }
                    else
                    {

                        var result = await _userManager.CreateAsync(user, model.Password);


                        if (result.Succeeded)
                        {
                            if (!string.IsNullOrEmpty(user.Role))
                            {
                                result = await _userManager.AddToRoleAsync(user, user.Role);
                            }

                            //mensaje.Titulo = "Usuario Creado";

                            //mensaje.Texto = "El usuario se creó satisfactoriamente";

                            //mensaje.Tipo = "success";

                            //EnviarMensaje.Enviar(TempData, "green", "El usuario se creó satisfactoriamente");


                            return RedirectToAction("Index", "Usuario");
                        }

                        //mensaje.Titulo = "Hubo un problema";

                        if (result.Errors.First().Code == "DuplicateUserName")
                        {
                            //mensaje.Texto = "El nombre de usuario ya exite, intenten con otro";

                        }

                    }

                    //mensaje.Tipo = "error";
                    //ViewBag.mensaje = mensaje;

                    return View("Register", model);

                }
                catch (System.Exception e)
                {
                    var error = e;
                    return View(model);
                }

            }

            return View("Register", model);
        }



        public IActionResult AddAddress()
        {
            return View();
        }

        public IActionResult Address()
        {
            return View();
        }  
        
        
        public IActionResult ShippingAddress()
        {
            return View();
        } 
        
        public IActionResult BillingAddress()
        {
            return View();
        }

        public IActionResult UserProfile()
        {

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Usuarios user = _userManager.FindByIdAsync(userId).Result;


            var model = CopyProperties.Convert<Usuarios, UsuariosModel>(user);

            return View(model);
        }


       public IActionResult UserGeneralInformation()
        {
            return View();
        }


     
    }
}
