using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc_EF.Models
{
    public class ClienteContext : DbContext
    {
        public ClienteContext() : base("ClienteContext")
        {
            //Desabilita a criacao do banco de dados
            Database.SetInitializer<ClienteContext>(null);
        }

        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Tipo> tipos { get; set; }


    }
}