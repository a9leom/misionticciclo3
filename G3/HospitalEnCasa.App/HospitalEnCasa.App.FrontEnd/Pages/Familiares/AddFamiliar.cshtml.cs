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

    public class AddFamiliarModel : PageModel
    {
        private readonly IRepositorioFamiliarDesignado repositorioFamiliarDesignado;

        public AddFamiliarModel(IRepositorioFamiliarDesignado repositorioFamiliarDesignado)
        {
            this.repositorioFamiliarDesignado = repositorioFamiliarDesignado;
        }
        public Familiar_Designado familiar { get; set; }
        public void OnGet()
        {
            familiar = new Familiar_Designado();
        }

        public IActionResult OnPost(Familiar_Designado familiar)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repositorioFamiliarDesignado.addFamiliarDesignado(familiar);
                    return RedirectToPage("./ListFamiliar");
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
