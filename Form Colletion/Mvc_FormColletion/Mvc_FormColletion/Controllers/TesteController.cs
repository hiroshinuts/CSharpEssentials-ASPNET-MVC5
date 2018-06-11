using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_FormColletion.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection formulario)
        {
            foreach (string chave in formulario)
            {
                ViewData[chave] = formulario[chave];
            }
            return View();
        }
    }
}