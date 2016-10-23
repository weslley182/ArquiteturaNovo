using ArquiteturaNovo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaNovo.Infra.Data.Context
{
    public class ProjModeloContext: DbContext
    {
        public ProjModeloContext()
            : base("ProjModelo")
        {

        }

        public DbSet<Cliente> Clientes { get; set}

    }
}
