using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AutoEscolaPDC.DAO;

namespace AutoEscolaPDC.Pages.Treinamentos
{
    public class EditModel : PageModel
    {
        private readonly AutoEscolaPDC.DAO.AutoEscolaPDCContext _context;

        public EditModel(AutoEscolaPDC.DAO.AutoEscolaPDCContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Treinamento Treinamento { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Treinamento = await _context.Treinamentos
                .Include(t => t.Aluno)
                .Include(t => t.Categoria)
                .Include(t => t.Funcionario).FirstOrDefaultAsync(m => m.ID == id);

            if (Treinamento == null)
            {
                return NotFound();
            }
           ViewData["AlunoID"] = new SelectList(_context.Alunos, "ID", "Nome");
           ViewData["CategoriaID"] = new SelectList(_context.Categorias, "ID", "Nome");
           ViewData["FuncionarioID"] = new SelectList(_context.Funcionarios, "ID", "ANome");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Treinamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TreinamentoExists(Treinamento.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TreinamentoExists(int id)
        {
            return _context.Treinamentos.Any(e => e.ID == id);
        }
    }
}
