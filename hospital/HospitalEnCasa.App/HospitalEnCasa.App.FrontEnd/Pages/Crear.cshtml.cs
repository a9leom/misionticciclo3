using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospitalEnCasa.app.Persistencia;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.App.FrontEnd
{
    public class CrearModel : PageModel
    {
        private readonly IRepositorioPersona repositorioPersona;
        public Persona persona {get; set;}

        public CrearModel(IRepositorioPersona repositorioPersona){
            this.repositorioPersona = repositorioPersona;
        }
        public void OnGet()
        {
            persona = new Persona();
        }
        public IActionResult OnPost(Persona persona){
            repositorioPersona.agregarPersona(persona);
            return RedirectToPage("/List");
        }
    }
}
