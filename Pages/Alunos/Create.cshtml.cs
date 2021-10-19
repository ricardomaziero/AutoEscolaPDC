﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AutoEscolaPDC.DAO;

namespace AutoEscolaPDC.Pages.Alunos
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
            return Page();
        }

        [BindProperty]
        public Aluno Aluno { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Alunos.Add(Aluno);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
