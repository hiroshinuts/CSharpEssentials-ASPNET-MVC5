using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_AjaxBeginForm.Models;

namespace Mvc_AjaxBeginForm.Controllers
{
    public class ProdutoController : Controller
    {
        NorthwindEntities ctx = new NorthwindEntities();

        // GET: Produto
        public ActionResult Index()
        {
            //var model = ctx.Products.Take(3).ToList();
            //return View(model);
            return View();
        }

        public PartialViewResult Localizar(string criterio)
        {
            List<Product> produtos = new List<Product>();

            if (!string.IsNullOrWhiteSpace(criterio))
            {
                produtos = (from p in ctx.Products
                            where p.ProductName.Contains(criterio)
                            select p).AsParallel().ToList();
            }
            return PartialView("_Produtos", produtos);
        }
    }
}