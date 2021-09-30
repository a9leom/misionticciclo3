using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalEnCasa.app.Dominio;
using HospitalEnCasa.app.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalEnCasa.App.FrontEnd.Pages
{
    public class CrearEnfermeraModel : PageModel
    {
        private IRepositorioEnfermera repositorioEnfermera;
        public Enfermera enfermera { get; set; }
        public CrearEnfermeraModel(IRepositorioEnfermera repositorioEnfermera)
        {
            this.repositorioEnfermera = repositorioEnfermera;
            Enfermera enfermera = new Enfermera();
        }
        public void OnGet()
        {

        }

        public IActionResult OnPost(Enfermera enfermera)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    repositorioEnfermera.addEnfermera(enfermera);
                    return RedirectToPage("./ListarEnfermeras");
                }
                catch
                {
                    return RedirectToPage("../Error");
                }
            }
            else
            {
                return Page();
            }
        }

    }
}
