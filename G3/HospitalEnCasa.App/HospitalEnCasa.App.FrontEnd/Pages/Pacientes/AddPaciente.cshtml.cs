using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalEnCasa.app.Dominio;
using HospitalEnCasa.app.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HospitalEnCasa.App.FrontEnd.Pages
{
    public class AddPacienteModel : PageModel
    {
        private readonly IRepositorioPaciente repositorioPaciente;
        private readonly IRepositorioMedico repositorioMedico;
        private readonly IRepositorioFamiliarDesignado repositorioFamiliarDesignado;

        private readonly IRepositorioEnfermera repositorioEnfermera;
        public Paciente paciente {get; set; }
        
        public IEnumerable<SelectListItem> medicos { get; set; }
        public int cedulaMedico{get; set;}
        public AddPacienteModel(IRepositorioPaciente repositorioPaciente,IRepositorioMedico repositorioMedico, IRepositorioFamiliarDesignado repositorioFamiliarDesignado, IRepositorioEnfermera repositorioEnfermera){
            this.repositorioPaciente = repositorioPaciente;
            this.repositorioMedico = repositorioMedico;
            this.repositorioEnfermera = repositorioEnfermera;
            this.repositorioFamiliarDesignado = repositorioFamiliarDesignado;
        }
        public void OnGet()
        {
            paciente = new Paciente();
            medicos = repositorioMedico.getAllMedicos().Select(
                a => new SelectListItem { 
                    Value = Convert.ToString(a.cedula),
                    Text = a.nombre
                }
            ).ToList();
        }

        public IActionResult OnPost(Paciente paciente, int cedulaMedico
        ){
            Medico medico = repositorioMedico.getMedico(cedulaMedico);   
            try{
                repositorioPaciente.addPaciente(paciente);
                paciente.medico = medico;
                repositorioPaciente.editPaciente(paciente);
                return RedirectToPage("./ListPaciente");
            }catch(Exception e){
                Console.WriteLine(e);
                return RedirectToPage("../Error");
            }
        }
    }
}
