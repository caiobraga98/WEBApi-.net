using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiCursos.Models
{
    public class ProjetoContext : DbContext
    {
        public ProjetoContext() : base("projetolocal")
        {
                
        }

        public DbSet<Curso> Cursos { get; set; }

    }
}