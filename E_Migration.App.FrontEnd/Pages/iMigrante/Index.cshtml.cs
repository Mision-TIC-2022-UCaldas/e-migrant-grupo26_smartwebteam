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
    public class IndexModel : PageModel
    {
        //Crear un objeto para uso de los repositorios
        private readonly IRepositorioMigrante _repoMigrante;
        //Modelo u objeto para transportar hacia EntrenadorIndex 
        public IEnumerable<Migrante> Migrantes {get; set; }

        //Constructor
        public IndexModel(IRepositorioMigrante repoMigrante)
        {
            this._repoMigrante = repoMigrante;
        }

        public void OnGet()
        {
            Migrantes = _repoMigrante.GetAllMigrantes();
        }
    }
}
