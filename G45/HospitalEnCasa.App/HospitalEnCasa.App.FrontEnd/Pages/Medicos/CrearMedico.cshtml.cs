using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospitalEnCasa.app.Persistencia;
using HospitalEnCasa.app.Dominio;

namespace MyApp.Namespace
{
    public class CrearMedicoModel : PageModel
    {
        private readonly IRepositorioMedico repositorioMedico;
        public Medico medico {get; set; }

        public CrearMedicoModel(IRepositorioMedico repositorioMedico){
            this.repositorioMedico = repositorioMedico;
        }
        public void OnGet()
        {
            medico = new Medico();
        }

        public IActionResult OnPost(Medico medico){

            try{
                repositorioMedico.addMedico(medico);
                return RedirectToPage("./ListaMedicos");
            }
            catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
