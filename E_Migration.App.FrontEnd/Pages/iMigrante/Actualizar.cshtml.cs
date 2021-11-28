using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Migration.App.Dominio;
using E_Migration.App.Persistencia;

namespace E_Migration.App.Frontend.Pages.iMigrante
{
    public class ActualizarModel : PageModel
    {
        //Objeto para utilizar el repositorio
        private readonly IRepositorioMigrante _repoMigrante;

        [BindProperty]
        public Migrante Migrante{ get; set; }

        // Constructor
        public ActualizarModel(IRepositorioMigrante repoMigrante)
        {
            this._repoMigrante = repoMigrante;
        }


        public ActionResult OnGet(int id)
        {
            Migrante=_repoMigrante.GetMigrante(id);
            if(Migrante!=null){
                return Page();
            }
            else
            {
                return RedirectToPage("./Index");
            }
        }

        public ActionResult OnPost(){            
            bool funciono = _repoMigrante.UpdateMigrante(Migrante);
            if(funciono){
                return RedirectToPage("./Index");
            }
            else{
                ViewData["Mensaje"]="Se ha presentado un error...";
                return Page();
            }
  
        }
    }
}
