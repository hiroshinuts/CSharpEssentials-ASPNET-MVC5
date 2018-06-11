using Mvc_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Demo.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Detalhe()
        {

            //logica de acesso aos dados usando entidades
            //ado.net, entity framework , Nhibernate
            Cliente cliente = new Cliente()
            {
                ClienteId = 200,
                Nome = "Rafael",
                Email = "rafael.com.br",
                Telefone = "11 99999-9999"
            };

            //passando com ViewBag
            ViewBag.ClienteId = cliente.ClienteId;
            ViewBag.Nome = cliente.Nome;

            //Deve passar o cliente para view, se não ocorre NullReference
            return View(cliente);
        }

        //Pegando parametro por parametro
        //public ActionResult SalvarCliente(int clienteId, string nome, string email, string telefone)
        //{
        //    //implementar logica para salvar
        //    ViewBag.ClienteId = clienteId;
        //    ViewBag.Nome = nome;
        //    ViewBag.Email = email;
        //    ViewBag.Telefone = telefone;
        //    return View();
        //}


        //FormCollection
        //public ActionResult SalvarCliente(FormCollection cli)
        //{
        //    //implementar logica para salvar
        //    ViewBag.ClienteId = cli["ClienteId"];
        //    ViewBag.Nome = cli["Nome"];
        //    ViewBag.Email = cli["Email"];
        //    ViewBag.Telefone = cli["Telefone"];


        //    return View();
        //}

        [HttpPost]
        public ActionResult SalvarCliente(Cliente cli)
        {
            return View(cli);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}