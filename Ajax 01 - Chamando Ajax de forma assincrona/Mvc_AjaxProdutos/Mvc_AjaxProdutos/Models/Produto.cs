using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Mvc_AjaxProdutos.Models
{
    [Table(Name ="Produtos")]
    public class Produto
    {
        [Column(IsPrimaryKey =true)]
        public int Id { get; set;  }
        [Column]
        public string Nome { get; set; }
        [Column]
        public string Descricao { get; set; }
        [Column]
        public decimal Preco { get; set; }
        [Column]
        public int Estoque { get; set; }
    }
}
