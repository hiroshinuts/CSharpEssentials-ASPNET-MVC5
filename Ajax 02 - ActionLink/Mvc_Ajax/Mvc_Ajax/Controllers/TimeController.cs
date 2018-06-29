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
            ViewBag.Mensagem = "Geral";
            List<Time> model = db.Times.ToList();
            return PartialView("_Times", model);
        }

        //retornra os 4 primeiros classificados
        public PartialViewResult Libertadores()
        {
            ViewBag.Mensagem = "Libertadores";
            List<Time> model = db.Times.OrderByDescending(x => x.Pontos).Take(4).ToList();
            return PartialView("_Times", model);
        }

        //retornra os 4 últimos classificados
        public PartialViewResult Rebaixados()
        {
            ViewBag.Mensagem = "Rebaixados";
            List<Time> model = db.Times.OrderBy(x => x.Pontos).Take(4).ToList();
            return PartialView("_Times", model);
        }
    }
}