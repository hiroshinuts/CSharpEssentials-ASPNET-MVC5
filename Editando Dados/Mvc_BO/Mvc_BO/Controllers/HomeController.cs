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

        public ActionResult Create()
        {
            return View();
        }


        //ModelBinding
        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                AlunoBLL _aluno = new AlunoBLL();
                _aluno.IncluirAluno(aluno);

                return RedirectToAction("Index");

            }
            return View();
        }

        //Get
        public ActionResult Edit(int id)
        {
            AlunoBLL alunoBll = new AlunoBLL();
            Aluno aluno = alunoBll.getAlunos().Single(x => x.Id == id);
            return View(aluno);
        }


        //Model Binding
        //[HttpPost]
        //[ActionName("Edit")]
        //public ActionResult Edit(Aluno aluno)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        AlunoBLL alunoBll = new AlunoBLL();
        //        alunoBll.AtualizarAluno(aluno);

        //        return RedirectToAction("Index");
        //    }
        //    return View(aluno);
        //}

        //UpdateModel Protegendo contra Injection Com UpdateModel Include Property
        //[HttpPost]
        //[ActionName("Edit")]
        //public ActionResult Edit_Post(int id)
        //{
        //    AlunoBLL alunoBll = new AlunoBLL();
        //    Aluno aluno = alunoBll.getAlunos().Single(x => x.Id == id);
        //    UpdateModel(aluno, includeProperties: new[] { "Id", "Email", "Idade", "DataInscricao", "Sexo" });

        //    if (ModelState.IsValid)
        //    {         
        //        alunoBll.AtualizarAluno(aluno);

        //        return RedirectToAction("Index");
        //    }
        //    return View(aluno);
        //}

        //UpdateModel Protegendo contra Injection Com UpdateModel Exclude Property -- Nao deixando Editar o Nome
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id)
        {
            AlunoBLL alunoBll = new AlunoBLL();
            Aluno aluno = alunoBll.getAlunos().Single(x => x.Id == id);
            UpdateModel(aluno,null, null, excludeProperties: new[] { "Nome" });

            if (ModelState.IsValid)
            {
                alunoBll.AtualizarAluno(aluno);

                return RedirectToAction("Index");
            }
            return View(aluno);
        }

    }
}