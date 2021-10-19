using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoEscolaPDC.Pages.Funcionarios;
using AutoEscolaPDC.Pages.Alunos;
using AutoEscolaPDC.Pages.Categorias;

namespace AutoEscolaPDC.Pages.Treinamentos
{
    public class Treinamento
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Data de Início")]
        [DataType(DataType.Date)]
        public DateTime? DtInicio { get; set; }

        [Display(Name = "Instrutor")]
        [ForeignKey("Funcionario")]
        public int FuncionarioID { get; set; }
        public Funcionario Funcionario { get; set; }
        
        [ForeignKey("Aluno")]
        [Display(Name = "Aluno")]
        public int AlunoID { get; set; }
        public Aluno Aluno { get; set; }

        [ForeignKey("Categoria")]
        [Display(Name = "Categoria")]
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
    }
}