using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AutoEscolaPDC.DAO;

namespace AutoEscolaPDC.Pages.Treinamentos
{
    public class IndexModel : PageModel
    {
        private readonly AutoEscolaPDC.DAO.AutoEscolaPDCContext _context;

        public IndexModel(AutoEscolaPDC.DAO.AutoEscolaPDCContext context)
        {
            _context = context;
        }

        public IList<Treinamento> Treinamento { get;set; }

        public async Task OnGetAsync()
        {
            Treinamento = await _context.Treinamentos
                .Include(t => t.Aluno)
                .Include(t => t.Categoria)
                .Include(t => t.Funcionario).ToListAsync();
        }
    }
}
