using Mvc_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_EF.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index(int TipoId)
        {
            using (ClienteContext clienteContext = new ClienteContext())
            {
                //retorna todos clientes
                //List<Cliente> clientes = clienteContext.clientes.ToList();

                //Retorna com Filtro
                List<Cliente> clientes = clienteContext.clientes.Where(cli => cli.TipoId == TipoId).ToList();
                return View(clientes);
            }

        }

        public ActionResult Detalhes(int id)
        {
            using (ClienteContext clienteContext = new ClienteContext())
            {
                Cliente cliente = clienteContext.clientes.Single(cli => cli.ClienteId == id);
                return View(cliente);
            }
        }
    }
}