using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_RoutingAtributo.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Idioma { get; set; }
        public int AnoPublicacao { get; set; }
        public Decimal Preco { get; set; }
    }
}