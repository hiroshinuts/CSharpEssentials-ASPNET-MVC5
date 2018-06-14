using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mvc_Rotas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Rotas Amigaveis
            routes.MapRoute
            (
                "Produtos",
                "Produtos/",
                new {controller = "Produto", action = "Index"}
            );

            //Rotas Amigaveis
            routes.MapRoute
            (
               "Detalhes",
               "Produtos/{produtoId}",
                new { controller = "Produto", action = "Detalhes" },
                //Restringir espera um caractere numero, se nao for, vai para proximo route
                new { produtoId = @"\d+"}
            );

            //Rotas Amigaveis - Cadastrar
            routes.MapRoute
            (
                "Cadastro",
                "Produtos/Cadastrar",
                new { controller = "Produto", action = "Cadastrar" }
            );


            //Rotas Amigaveis
            routes.MapRoute
            (
                "Categorias",
                "Produtos/{categoria}",
                new { controller = "Produto", action = "Categorias" }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Produto", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
