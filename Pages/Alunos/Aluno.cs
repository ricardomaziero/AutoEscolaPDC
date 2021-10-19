using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoEscolaPDC.Pages.Treinamentos;
using AutoEscolaPDC.Pages.Categorias;

namespace AutoEscolaPDC.Pages.Alunos
{
    public class Aluno
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Mínimo 3, máximo 50 caractéres")]
        public string Nome { get; set; }
        
        public string Sexo { get; set; }

        public int Idade { get; set; }

        
    }
}
