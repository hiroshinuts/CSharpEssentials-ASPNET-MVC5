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



        //UpdateModel Protegendo contra Injection Com UpdateModel Exclude Property -- Nao deixando Editar o Nome
        [HttpPost]
        [ActionName("Edit")]
        //public ActionResult Edit_Post([Bind(Include ="Id, Email, Idade, DataInscricao, Sexo")]Aluno aluno) //Protegendo com Bind, O nome vem Null dessa forma
        public ActionResult Edit_Post([Bind(Exclude = "Nome")]Aluno aluno) //Protegendo com Bind, O nome vem Null dessa forma
        {
            AlunoBLL alunoBll = new AlunoBLL();
            aluno.Nome = alunoBll.getAlunos().Single(x => x.Id == aluno.Id).Nome; //Pegar a informacao do nome para preencher e nao deixar editar


            //Aluno aluno = alunoBll.getAlunos().Single(x => x.Id == id);
            //UpdateModel(aluno,null, null, excludeProperties: new[] { "Nome" });

            if (ModelState.IsValid)
            {
                alunoBll.AtualizarAluno(aluno);

                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        //Delete Via Get(Nao recomendado)
        //[ActionName("Delete")]
        //public ActionResult Delete_Get(int id)
        //{
        //    AlunoBLL alunoBll = new AlunoBLL();
        //    alunoBll.DeletarAluno(id);
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public ActionResult Delete(int id)
        {
            AlunoBLL alunoBll = new AlunoBLL();
            alunoBll.DeletarAluno(id);
            return RedirectToAction("Index");
        }

        //Comentado pq o delete vai ser via JS
        //[ActionName("Delete")]
        //[HttpPost]
        //public ActionResult Delete_Post(Aluno aluno)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        AlunoBLL alunoBll = new AlunoBLL();
        //        alunoBll.DeletarAluno(aluno.Id);
        //        return RedirectToAction("Index");
        //    }

        //    return View(aluno);
        //}


    }
}