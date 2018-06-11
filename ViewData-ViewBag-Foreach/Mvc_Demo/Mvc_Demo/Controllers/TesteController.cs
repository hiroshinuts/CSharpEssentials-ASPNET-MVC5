using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Demo.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public string Index()
        {
            return "Retornado pelo controlador TesteController";
        }
    }
}