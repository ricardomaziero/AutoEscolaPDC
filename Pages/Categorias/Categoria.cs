using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using AutoEscolaPDC.Pages.Treinamentos;
using AutoEscolaPDC.Pages.Alunos;
using AutoEscolaPDC.Pages.Funcionarios;

namespace AutoEscolaPDC.Pages.Categorias
{
    public class Categoria
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "Mínimo 1, máximo 3 caractéres")]
        [Display(Name = "Categoria")]
        public string Nome { get; set; }

        public IEnumerable<Treinamento> Treinamentos { get; set; }
        
    }
}
