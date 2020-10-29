using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PeligroSport.Areas.Identity.Models;
using PeligroSport.Core.Entities;
using PeligroSport.Core.Interfaces;
using PeligroSport.Helpers;
using System.Linq;
using System.Threading.Tasks;

namespace PeligroSport.Areas.Identity.Controlers
{

    [Area("Identity"), ReturnArea("Account")]
    public class AccountController : Controller
    {

        private readonly SignInManager<Usuarios> _signInManager;
        private readonly UserManager<Usuarios> _userManager;
        private readonly IUsuarios _usuarios;
        //private readonly IRole _role;
        private IConfiguration _config;

        public AccountController(SignInManager<Usuarios> signInManager, UserManager<Usuarios> userManager,
            IUsuarios usuarios)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _usuarios = usuarios;
        }


        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {

            if (!ModelState.IsValid) return View(model);

            var usuario = _usuarios.GetAll.FirstOrDefault(x => x.UserName == model.UserName);

            if (usuario != null)
            {


                //if (usuario.Role == RoleName.GestionUniversitaria && usuario.UniversityId == null)
                //{
                //    TempData.Enviar("Este usuario debe esperar por la asignación de una universidad", "error", "Verifique el nombre del usuario o contacte al administrador");

                //    return View(model);
                //}

                var estado = _usuarios.GetAll.Where(n => n.UserName == model.UserName).Select(x => x.Estado).AsQueryable().Single();

                if (estado == true)
                {

                    var result = await _signInManager.PasswordSignInAsync(model.UserName,
                 model.Password, model.RememberMe, false);

                    if (result.Succeeded)
                    {

                        return RedirectToAction("Index", "Home", new { area = "" });

                    }

                    if (result.RequiresTwoFactor)
                    {
                        return RedirectToPage("./LoginWith2fa", new
                        {
                            ReturnUrl = returnUrl,
                            RememberMe = model.RememberMe
                        });
                    }

                    if (result.IsLockedOut)
                    {
                        return RedirectToPage("./Lockout");
                    }
                    else
                    {

                        //TempData.Enviar("Datos incorrectos", "error", "La Contraseña o el usuario no coinciden");

                        return View(model);
                    }
                }

                else
                {
                    //TempData.Enviar("Usuario Inactivo", "error", "Contacte al administrador del sistema");

                    return View(model);
                }


                //}
            }

            else
            {

                //TempData.Enviar("Este usuario no existe", "error", "Verifique el nombre del usuario o contacte al administrador");

                return View(model);
            }

            return View(model);

        }



        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home", new { area = "" });
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
