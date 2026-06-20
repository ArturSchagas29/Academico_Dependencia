using Academico_Dependencia.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Academico_Dependencia.Data
{
    public class AcademicoContext : DbContext
    {
        public AcademicoContext(DbContextOptions<AcademicoContext> options) : base(options)
        {
        }

        public DbSet<Instituicao> Instituicoes { get; set; }
        
        public DbSet<Departamento> Departamentos { get; set; }

        public DbSet<Aluno> Alunos { get; set; }
    }
}