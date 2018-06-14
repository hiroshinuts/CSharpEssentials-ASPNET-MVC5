using System;
using System.Web.Mvc;

namespace Mvc_RoutingAtributo.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        // rota /Teste/Index
        public ActionResult Index()
        {
            ViewBag.Message = "Página de apresentação (Controller => Teste)";
            return View();
        }

        [Route("raiz/{numero}")] //rota: /raiz/numero
        public ActionResult Raiz(double numero)
        {
            ViewBag.Message = "Calculo da Raiz Quadrada - Macoratti .net";
            ViewBag.Numero = numero;
            return View(Math.Sqrt(numero));
        }

        [Route("usuarios/sobre")]  //rota  /usuarios/sobre
        public ActionResult Sobre()
        {
            ViewBag.Message = "Página Sobre - Macoratti .net";
            return View();
        }

        //rota: /Teste/Contato
        public ActionResult Contato()
        {
            ViewBag.Message = "Página de Contato :  http://www.macoratti.net";
            return View();
        }
    }
}