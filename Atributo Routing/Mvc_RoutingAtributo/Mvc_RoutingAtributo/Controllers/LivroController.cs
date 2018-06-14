using System.Web.Mvc;
using Mvc_RoutingAtributo.Models;

namespace Mvc_RoutingAtributo.Controllers
{
    public class LivroController : Controller
    {
        // rota /Livro/Index
        public ActionResult Index()
        {
            ViewBag.Message = " Livraria - Página de apresentação ( Controller => Livro)";
            return View();
        }

        // rota : /livros
        // rota : /livros/100
        [Route("livros/{id?}")]
        public ActionResult Livro(int? id)
        {
            Livraria livro = new Livraria();

            //verifica se id é igual a null
            if (id == null)
            {
                //lista todos os livros
                return View("Livros", livro.GetLivros());
            }
            else
            {
                //lista um livro pelo o seu id
                return View("Livro", livro.GetLivroPorId(id));
            }
        }

        // ex: /livros/idioma
        // ex: /livros/idioma/en
        // ex: /livros/idioma/fr 
        [Route("livros/idioma/{idioma=pt}")]
        public ActionResult LivroPorIdioma(string idioma)
        {
            Livraria livro = new Livraria();
            return View("Livros", livro.GetLivrosPorIdioma(idioma));
        }
    }
}