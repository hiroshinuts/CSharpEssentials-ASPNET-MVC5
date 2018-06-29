using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_AjaxProdutos.Models;
using System.Data.Linq;

namespace Mvc_AjaxProdutos.Controllers
{
    public class HomeController : Controller
    {
        DataContext contexto;

        public HomeController()
        {
            this.contexto = new DataContext(ProdutoContexto.conexaoBD);
        }

        public PartialViewResult GetProdutos()
        {
            List<Produto> produtos = contexto.GetTable<Produto>().ToList();
            return PartialView(produtos);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}