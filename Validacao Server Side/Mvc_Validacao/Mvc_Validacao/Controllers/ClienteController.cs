using Mvc_Validacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Validacao.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new Cliente();
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {
            //validacao do lado do servidor
            if (string.IsNullOrEmpty(cliente.Nome))
            {
                ModelState.AddModelError("Nome", "O Nome é obrigatorio");
            }

            if (string.IsNullOrEmpty(cliente.Email))
            {
                ModelState.AddModelError("Email", "O Email é obrigatorio");
            }

            if (string.IsNullOrEmpty(cliente.Telefone))
            {
                ModelState.AddModelError("Telefone", "O Telefone é obrigatorio");
            }

            if(cliente.Idade == 0)
            {
                ModelState.AddModelError("Idade", "A idade é obrigatoria");
            }
            else
            {
                if(cliente.Idade <= 21)
                {
                    ModelState.AddModelError("Idade", "A idade informada deve ser maior que 21 anos");
                }
            }

            //a validacao falhou?
            if (!ModelState.IsValid)
            {
                return View(cliente);
            }
            else
            {
                return View("Validacao", cliente);
            }
        }

        public ActionResult Validacao(Cliente cliente)
        {
            return View(cliente);
        }
    }
}