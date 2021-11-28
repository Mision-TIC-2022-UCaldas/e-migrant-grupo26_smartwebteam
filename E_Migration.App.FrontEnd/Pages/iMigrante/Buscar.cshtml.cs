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
    public class BuscarModel : PageModel
    {
   
        private readonly IRepositorioMigrante _repoMigrante;

        public BuscarModel(IRepositorioMigrante repoMigrante){
            this._repoMigrante = repoMigrante;
            
        }

        //Propiedad para comunicacion con el cshtml
        [BindProperty]
        public Migrante Migrante{get;set;}
        //public Equipo Equipo{get;set;}

        public ActionResult OnGet(int Id)
        {
            Migrante=_repoMigrante.GetMigrante(Id);
            
            if(Migrante!=null){                
                return Page();
            }
            else
            {
                return RedirectToPage("./Index");
            }
        }

    }
}
