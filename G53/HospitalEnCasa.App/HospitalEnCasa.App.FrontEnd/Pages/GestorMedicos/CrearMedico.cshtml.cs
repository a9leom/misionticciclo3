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
    public class CrearMedicoModel : PageModel
    {
        private IRepositorioMedico repositorioMedico;
        public Medico medico { get; set; }
        public CrearMedicoModel(IRepositorioMedico repositorioMedico){
            this.repositorioMedico = repositorioMedico;
        }
        public void OnGet()
        {
            Medico medico = new Medico();
        }

        public IActionResult OnPost(Medico medico){
            try{
                repositorioMedico.addMedico(medico);
                return RedirectToPage("./ListMedico");
            }
            catch{
                return RedirectToPage("../Error");
            }
        }


    }
}
