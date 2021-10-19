using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using AutoEscolaPDC.Pages.Treinamentos;
using AutoEscolaPDC.Pages.Categorias;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoEscolaPDC.Pages.Funcionarios
{
    public class Funcionario
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Mínimo 3, máximo 50 caractéres")]
        [Display(Name = "Nome")]
        public string ANome { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Mínimo 4, máximo 20 caractéres")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Senha deve conter 8 caracteres")]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        public int Idade { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Mínimo 3, máximo 50 caractéres")]
        public string Cargo { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DtAdmissao { get; set; }

        public IEnumerable<Treinamento> Treinamentos { get; set; }

    }
}
