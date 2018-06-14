using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_RoutingAtributo.Models
{
    public class Livraria
    {
        List<Livro> lista;

        public Livraria()
        {
            lista = new List<Livro>()
            {
                    new Livro { Id=100 , ISBN="8585943963", Titulo="ASP, ADO e Banco de dados na Internet",Autor="Jose C Macoratti", Idioma="Portugues", AnoPublicacao=2000, Preco=25.00M  },
                    new Livro { Id=200 , ISBN="7581043963", Titulo="Liberty and Fight",Autor="Peter Alan", Idioma="Ingles", AnoPublicacao=2010, Preco=45.00M  },
                    new Livro { Id=300 , ISBN="9605443963", Titulo="Visual Basic Básico",Autor="Paulo Moreira", Idioma="Portugues", AnoPublicacao=2005, Preco=75.00M  },
                    new Livro { Id=400 , ISBN="8585995163", Titulo="ASP .NET MVC - Introducao",Autor="Ana Lima", Idioma="Portugues", AnoPublicacao=2009, Preco=60.00M  },
                    new Livro { Id=400 , ISBN="9506848500", Titulo="Le Femme",Autor="Pierr Augustin", Idioma="Frances", AnoPublicacao=2009, Preco=60.00M  },
                    new Livro { Id=500 , ISBN="8585985640", Titulo="Entity Framework Professional",Autor="Carl Pruden", Idioma="Ingles", AnoPublicacao=2012, Preco=35.00M  }
            };
        }

        //exibe um livro por id
        public Livro GetLivroPorId(int? id)
        {
            return (lista.FirstOrDefault(livro => livro.Id == id));
        }

        //exibe todos os livros
        public List<Livro> GetLivros()
        {
            return lista;
        }

        //exibe livros pelo idioma
        public List<Livro> GetLivrosPorIdioma(string idioma)
        {
            if (idioma == "en")
                idioma = "Ingles";
            else if (idioma == "pt")
                idioma = "Portugues";
            else if (idioma == "fr")
                idioma = "Frances";

            return (lista.Where(livro => livro.Idioma == idioma).ToList());
        }
    }
}