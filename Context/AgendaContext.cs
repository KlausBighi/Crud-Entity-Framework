using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions <AgendaContext> options) : base(options)
        {
            //Recebe a conexão do banco e passa para a base(options)
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}