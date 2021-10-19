using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AutoEscolaPDC.DAO;

namespace AutoEscolaPDC.Pages.Treinamentos
{
    public class CreateModel : PageModel
    {
        private readonly AutoEscolaPDC.DAO.AutoEscolaPDCContext _context;

        public CreateModel(AutoEscolaPDC.DAO.AutoEscolaPDCContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AlunoID"] = new SelectList(_context.Alunos, "ID", "Nome");
        ViewData["CategoriaID"] = new SelectList(_context.Categorias, "ID", "Nome");
        ViewData["FuncionarioID"] = new SelectList(_context.Funcionarios, "ID", "ANome");
            return Page();
        }

        [BindProperty]
        public Treinamento Treinamento { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Treinamentos.Add(Treinamento);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
