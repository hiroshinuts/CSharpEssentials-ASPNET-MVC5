using System.Collections.Generic;
using System.Web.Mvc;

namespace Mvc_TempData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<string> alunos = new List<string>()
            {
                "Macoratti", "Jefferson", "Miriam", "Janice"
            };

            ViewData["AlunosViewData"] = alunos;
            ViewBag.AlunosViewBag = alunos;
            TempData["AlunosTempData"] = alunos;
            Session["AlunosSession"] = alunos;

            //return RedirectToAction("Cadastrar");
            return View();
        }

        public ActionResult Cadastrar()
        {
            List<string> alunosViewData = (List<string>)ViewData["AlunosViewData"];
            List<string> alunosViewBag = ViewBag.AlunosViewBag;
            List<string> alunosTempData = (List<string>)TempData["AlunosTempData"];
            List<string> alunosSession = (List<string>)Session["AlunosSession"];

            ViewData["AlunosViewData"] = alunosViewData;
            ViewBag.AlunosViewBag = alunosViewBag;
            TempData["AlunosTempData"] = alunosTempData;
            Session["AlunosSession"] = alunosSession;

            
            return View();
        }
    }
}