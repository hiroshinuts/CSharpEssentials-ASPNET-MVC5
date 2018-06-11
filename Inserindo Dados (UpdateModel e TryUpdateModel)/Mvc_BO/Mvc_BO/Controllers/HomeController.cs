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

        //Usando FormColletion
        //[HttpPost]
        //public ActionResult Create(FormCollection formulario)
        //{
        //    AlunoBLL _aluno = new AlunoBLL();

        //    Aluno aluno = new Aluno();
        //    aluno.Nome = formulario["Nome"];
        //    aluno.Email = formulario["Email"];
        //    aluno.Idade = Convert.ToInt32(formulario["Idade"]);
        //    aluno.DataInscricao = Convert.ToDateTime(formulario["DataInscricao"]);
        //    aluno.Sexo = formulario["Sexo"];

        //    _aluno.IncluirAluno(aluno);

        //    return RedirectToAction("Index");
        //}

        //Recebendo Parametros
        //[HttpPost]
        //public ActionResult Create(string nome, string email, int idade, DateTime dataInscricao, string sexo)
        //{
        //    AlunoBLL _aluno = new AlunoBLL();

        //    Aluno aluno = new Aluno();
        //    aluno.Nome = nome;
        //    aluno.Email = email;
        //    aluno.Idade = idade;
        //    aluno.DataInscricao = dataInscricao;
        //    aluno.Sexo = sexo;

        //    _aluno.IncluirAluno(aluno);

        //    return RedirectToAction("Index");
        //}

        //ModelBinding
        //[HttpPost]
        //public ActionResult Create(Aluno aluno)
        //{
        //    AlunoBLL _aluno = new AlunoBLL();
        //    _aluno.IncluirAluno(aluno);

        //    return RedirectToAction("Index");
        //}

        //UpdatePanel - nao passa nenhum parametro
        //[HttpPost]
        ////Definir o nome da Action
        //[ActionName("Create")]
        //public ActionResult Create_Post()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Aluno aluno = new Aluno();
        //        UpdateModel(aluno);
        //        AlunoBLL _aluno = new AlunoBLL();
        //        _aluno.IncluirAluno(aluno);

        //        return RedirectToAction("Index");
        //    }

        //    return View();

        //}


        //TryUpdateModel
        [HttpPost]
        //Definir o nome da Action
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            Aluno aluno = new Aluno();
            TryUpdateModel(aluno);

            if (ModelState.IsValid)
            {
                AlunoBLL _aluno = new AlunoBLL();
                _aluno.IncluirAluno(aluno);

                return RedirectToAction("Index");

            }

            return View();

        }
    }
}