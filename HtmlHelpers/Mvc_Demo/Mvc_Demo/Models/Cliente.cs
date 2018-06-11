using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Demo.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }
    }
}