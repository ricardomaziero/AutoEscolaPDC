using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoEscolaPDC.Pages.Alunos;
using AutoEscolaPDC.Pages.Funcionarios;
using AutoEscolaPDC.Pages.Treinamentos;
using AutoEscolaPDC.Pages.Categorias;


namespace AutoEscolaPDC.DAO
{
    public class AutoEscolaPDCContext : DbContext
    {

        public AutoEscolaPDCContext(DbContextOptions<AutoEscolaPDCContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Treinamento> Treinamentos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

    }
}
