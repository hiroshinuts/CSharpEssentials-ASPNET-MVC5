using System.Web.Mvc;

namespace Mvc_RoutingAtributo.Controllers
{
    [RoutePrefix("Macoratti")]
    [Route("{action=index}")]  //rota padrão
    public class HomeController : Controller
    {
        // GET: Home
        // nova rota /Macoratti/Index
        public ActionResult Index()
        {
            ViewBag.Message = "Página de apresentação (Controller => Home)";
            return View();
        }

        //nova rota: /Macoratti/Sobre 
        public ActionResult Sobre()
        {
            ViewBag.Message = "Página Sobre  - Macoratti .net";
            return View();
        }

        //nova rota: /Macoratti/Contato 
        public ActionResult Contato()
        {
            ViewBag.Message = "Página de Contato = http://www.macoratti.net"; 
            return View();
        }

        [Route("~/home")]  //-> nova rota: /home
        public ActionResult Teste()
        {
            ViewBag.Message = "Página de Teste (Home)";
            return View();
        }
    }
}