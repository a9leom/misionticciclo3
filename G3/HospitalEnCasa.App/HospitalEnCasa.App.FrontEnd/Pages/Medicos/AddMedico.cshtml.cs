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
    public class AddMedicoModel : PageModel
    {
        private readonly IRepositorioMedico repositorioMedico;
        public Medico medico{get; set;}
        public AddMedicoModel(IRepositorioMedico repositorioMedico){
            this.repositorioMedico = repositorioMedico;
        }
        public void OnGet()
        {
            medico = new Medico();
        }

        public IActionResult OnPost(Medico medico){
            try{
                repositorioMedico.addMedico(medico);
                return RedirectToPage("./ListMedicos");
            }
            catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
