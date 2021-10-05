using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalEnCasa.app.Persistencia;
using HospitalEnCasa.app.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalEnCasa.App.FrontEnd.Pages
{
    public class DetailHistoriaModel : PageModel
    {
        private readonly IRepositorioHistoria repositorioHistoria;
        public Historia historia {get; set; }

        public DetailHistoriaModel(IRepositorioHistoria repositorio){
            this.repositorioHistoria = repositorio;
        }
        public void OnGet(int idHistoria)
        {
            historia = repositorioHistoria.getHistoria(idHistoria);
        }
    }
}
