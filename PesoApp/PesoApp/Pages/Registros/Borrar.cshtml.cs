using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PesoApp.Datos;
using PesoApp.Modelos;

namespace PesoApp.Pages.Registros
{
    public class BorrarModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;

        public BorrarModel(ApplicationDbContext contexto)
        {
            this._contexto = contexto;
        }

        [BindProperty]
        public Registro Registro { get; set; }

        public async void OnGet(int id)
        {
            Registro = await _contexto.Registro.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            var RegistroDesdeDb = await _contexto.Registro.FindAsync(Registro.Id);
            if (RegistroDesdeDb == null)
            {
                return NotFound();
            }
            _contexto.Registro.Remove(RegistroDesdeDb);
            await _contexto.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
