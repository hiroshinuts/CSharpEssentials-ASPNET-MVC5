using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Ajax.Models;

namespace Mvc_Ajax.Controllers
{
    public class TimeController : Controller
    {
        CadastroEntities db = new CadastroEntities();

        // GET: Time
        public ActionResult Index()
        {
            return View();
        }

        //retornar todos os times
        public PartialViewResult Geral()
        {
            System.Threading.Thread.Sleep(5000);
            ViewBag.Mensagem = "Geral";
            List<Time> model = db.Times.ToList();
            return PartialView("_Times", model);
        }

        //retornra os 4 primeiros classificados
        public PartialViewResult Libertadores()
        {
            System.Threading.Thread.Sleep(5000);
            ViewBag.Mensagem = "Libertadores";
            List<Time> model = db.Times.OrderByDescending(x => x.Pontos).Take(4).ToList();
            return PartialView("_Times", model);
        }

        //retornra os 4 últimos classificados
        public PartialViewResult Rebaixados()
        {
            System.Threading.Thread.Sleep(5000);
            ViewBag.Mensagem = "Rebaixados";
            List<Time> model = db.Times.OrderBy(x => x.Pontos).Take(4).ToList();
            return PartialView("_Times", model);
        }
    }
}