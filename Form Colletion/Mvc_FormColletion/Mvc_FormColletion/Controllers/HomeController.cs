using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_FormColletion.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection formulario)
        {
            foreach(string chave in formulario)
            {
                Response.Write("Chave = " + chave + " ");
                Response.Write("Valor = " + formulario[chave]);
                Response.Write("<br />");
            }
            return View();
        }

        public void SalvarCliente(FormCollection form1)
        {
            string nome = form1["nome"];
            string email = form1["email"];
            string sexo = form1["sexo"];
            string idade = form1["idade"];

            //logica para tratar os dados
            //CRUD
        }
    }
}