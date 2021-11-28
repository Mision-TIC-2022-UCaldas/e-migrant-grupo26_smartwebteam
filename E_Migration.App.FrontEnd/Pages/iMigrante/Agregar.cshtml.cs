using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Migration.App.Dominio;
using E_Migration.App.Persistencia;

namespace E_Migration.App.FrontEnd.Pages.iMigrante
{
    public class AgregarModel : PageModel
    {
        //Objeto para utilizar el repositorio
        private readonly IRepositorioMigrante _repoMigrante;
        //Propiedad para tarnsportar  al cshtml

        [BindProperty]
        public Migrante Migrante{ get; set; }

        // Constructor
        public AgregarModel(IRepositorioMigrante repoMigrante)
        {
            this._repoMigrante = repoMigrante;
        }

        public ActionResult OnGet()
        {
            //Patrocinadores = _repoPatrocinador.ListarPatrocinadores();
            return Page();
        }
        public ActionResult OnPost()
        {
            bool creado = _repoMigrante.AddMigrante(Migrante);
            if (creado)
            {
                ViewData["Mensaje"] = "Registro Exitoso.";
                //return RedirectToPage("./Index");
                return Page();
            }

            else
            {
                //viewData["repoMunicipio"] = creado;
                //=_repoEquipo.ListarEquipos();
                ViewData["Mensaje"] = "Esta persona ya está registrada.";
                return Page();
            }
        }
    }
}
