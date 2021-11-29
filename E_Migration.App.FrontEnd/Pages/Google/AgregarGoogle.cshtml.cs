using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using E_Migration.App.Dominio;
using E_Migration.App.Persistencia;

namespace E_Migration.App.FrontEnd.Areas.Identity.Pages.Account.Google
{
    public class AgregarGoogleModel : PageModel
    {
        //Objeto para utilizar el repositorio
        private readonly IRepositorioRegisGoogle _repoRegisGoogle;
        //Propiedad para tarnsportar  al cshtml

        [BindProperty]
        public RegisGoogle RegisGoogle{ get; set; }

        // Constructor
        public AgregarGoogleModel(IRepositorioRegisGoogle repoRegisGoogle)
        {
            this._repoRegisGoogle = repoRegisGoogle;
        }
        public ActionResult OnGet()
        {
            //Patrocinadores = _repoPatrocinador.ListarPatrocinadores();
            return Page();
        }
        public ActionResult OnPost()
        {
            bool creado = _repoRegisGoogle.AddRegisGoogle(RegisGoogle);
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
