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
    public class ListCitaModel : PageModel
    {
        private readonly IRepositorioCita repositorioCita;

        public IEnumerable<Cita> citas;

        public ListCitaModel(IRepositorioCita repositorio){
            this.repositorioCita = repositorio;
            citas = repositorioCita.getAllCitas();
        }
        public void OnGet()
        {
        }
    }
}
