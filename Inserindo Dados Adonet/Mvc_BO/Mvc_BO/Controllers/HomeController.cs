using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_BO.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Criei instancia da classe AlunoBLL
            AlunoBLL _aluno = new AlunoBLL();

            //Usando o metodo GetAluno, que entra no BD e retorna a lista de alunos
            List<Aluno> alunos = _aluno.getAlunos().ToList();

            return View(alunos);
        }
    }
}