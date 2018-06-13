using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc_EF.Models
{
    //Mapear para o EF
    [Table("Tipos")]
    public class Tipo
    {
        public int TipoId { get; set; }

        public string Nome { get; set; }

        //Criar o campo de relacionamento que lista os clientes
        public List<Cliente> Clientes { get; set; }
    }
}