using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalEnCasa.app.Dominio;
using HospitalEnCasa.app.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HospitalEnCasa.App.FrontEnd
{
    public class AddHistoriaModel : PageModel
    {

        private readonly IRepositorioHistoria repositorioHistoria;
        private readonly IRepositorioAnotacion repositorioAnotacion;

        public int idAnotacion { get; set; }
        public Historia historia { get; set; }

        public IEnumerable<SelectListItem> anotaciones { get; set; }
        
        public AddHistoriaModel(IRepositorioHistoria repositorio, IRepositorioAnotacion repositorioAnotacion){
            this.repositorioHistoria = repositorio;
            this.repositorioAnotacion = repositorioAnotacion;
            historia = new Historia();

            anotaciones = repositorioAnotacion.getAllAnotacion().Select(a => new SelectListItem{
                Text = a.paciente.nombre+" "+a.medico.nombre+" "+a.Id,
                Value = Convert.ToString(a.Id)
            });
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Historia historia, int idAnotacion){
            if(ModelState.IsValid){
                try{
                    repositorioHistoria.addHistoria(historia);
                    Anotacion anotacion = repositorioAnotacion.getAnotacionById(idAnotacion);
                    historia.anotacion = anotacion;
                    return RedirectToPage("./ListHistoria");
                }
                catch{
                    return RedirectToPage("../Error");
                }
            }
            else{
                return Page();
            }
        }
    }
}
