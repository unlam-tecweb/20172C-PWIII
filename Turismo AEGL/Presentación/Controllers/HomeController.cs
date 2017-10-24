﻿using System.Web.Mvc;
using Presentación.ViewModels;
using Dal;
using Logica.Models;

namespace Presentación.Controllers
{
    public class HomeController : Controller
    {
        private LogicaUsuario Logica = new LogicaUsuario();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            Usuario usuario;

            if (ModelState.IsValid)
            {
                usuario = Logica.TraerUsuario(model.Email, model.Contrasenia);

                if (usuario != null)
                {
                    Session["IdUsuario"] = usuario.Id;
                    Session["NombreUsuario"] = usuario.Nombre;
                    Session["Email"] = usuario.Email;
                    Session["EsAdmin"] = (usuario.Admin) ? true : false;

                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index");
        }
    }
}