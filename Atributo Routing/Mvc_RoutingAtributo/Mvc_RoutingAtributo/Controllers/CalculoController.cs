using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_RoutingAtributo.Controllers
{
    public class CalculoController : Controller
    {
        // GET: Calculo
        public ActionResult Index()
        {
            ViewBag.Message = "Página de apresentação (Controller => Calculo)";
            return View();
        }

        [Route("potencia/{numero:int:min(50)}")] //rota: /potencia/numero
        public ActionResult Potencia(int? numero)
        {
            ViewBag.Message = "Calculo da Potência ao quadrado de um Número - Macoratti .net";
            ViewBag.Numero = numero;
            return View(numero * numero);
        }

        [Route("saudacoes/{mensagem:maxlength(10)?}")]
        public ActionResult Saudacoes(string mensagem)
        {
            if (mensagem == null)
                mensagem = "Bem-Vindo";

            return View("/Views/Calculo/Saudacoes.cshtml", null, mensagem);
        }
    }
}