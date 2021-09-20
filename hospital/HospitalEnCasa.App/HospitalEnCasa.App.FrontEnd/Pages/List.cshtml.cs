using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospitalEnCasa.app.Persistencia;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.App.FrontEnd
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioPersona repositorioPersona;
        public IEnumerable<Persona> personas;

        public ListModel(IRepositorioPersona repositorioPersona){
            this.repositorioPersona = repositorioPersona;
        }
        public void OnGet()
        {
            personas = repositorioPersona.obtenerPersonas();
        }
    }
}
