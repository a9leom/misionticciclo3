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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioPersona repositorioPersona;
        public Persona persona {get; set;}
        public DetailsModel(IRepositorioPersona repositorioPersona){
            this.repositorioPersona = repositorioPersona;
        }
        public IActionResult OnGet(int cedula)
        {
            persona = repositorioPersona.obtenerPersona(cedula);  
            if(persona == null){
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }         
        }
    }
}
