using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //ViewData Passando valores para tela
            ViewData["Nome"] = "Rafael";
            ViewData["Email"] = "rafael@gmail.com";
            ViewData["Curso"] = "Asp.Net MVC";
            ViewData["DataInicio"] = new DateTime(2018, 07, 01);

            
            //ViewBag Passando valores para Tela
            ViewBag.Nome = "Rafael";
            ViewBag.Email = "rafael@gmail.com";
            ViewBag.Curso = "Asp.Net MVC";
            ViewBag.DataInicio = new DateTime(2018, 07, 01);


            //Foreach Paises usando ViewData
            ViewData["Paises0"] = new List<string>()
            {
                "Brasil",
                "Peru",
                "Argentina",
                "Japão"
            };


            //Foreach Paises usando ViewBag
            ViewBag.Paises = new List<string>()
            {
                "Brasil",
                "Peru",
                "Argentina",
                "Japão"
            };

            return View();
        }

        public string Inicio()
        {
            return "Minha primeira aplicação ASP.NET MVC";
        }

        public string Saudacao(int id)
        {
            return "Codigo recebido da url" + id.ToString();
        }
    }
}