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
    public class AddPacienteModel : PageModel
    {
        private readonly IRepositorioPaciente repositorioPaciente;
        private readonly IRepositorioMedico repositorioMedico;
        private readonly IRepositorioFamiliarDesignado repositorioFamiliarDesignado;

        private readonly IRepositorioEnfermera repositorioEnfermera;
        public Paciente paciente {get; set; }
        public IEnumerable<Paciente> pacientes {get; set; }
        public IEnumerable<Medico> medicos {get; set; }
        public IEnumerable<Familiar_Designado> familiares {get; set;}
        public IEnumerable<Enfermera> enfermeras {get; set;}
        public AddPacienteModel(IRepositorioPaciente repositorioPaciente,IRepositorioMedico repositorioMedico, IRepositorioFamiliarDesignado repositorioFamiliarDesignado, IRepositorioEnfermera repositorioEnfermera){
            this.repositorioPaciente = repositorioPaciente;
            this.repositorioMedico = repositorioMedico;
            this.repositorioEnfermera = repositorioEnfermera;
            this.repositorioFamiliarDesignado = repositorioFamiliarDesignado;
        }
        public void OnGet()
        {
            paciente = new Paciente();
            medicos = repositorioMedico.getAllMedicos();
            enfermeras = repositorioEnfermera.getAllEnfermeras();
            familiares = repositorioFamiliarDesignado.getAllFamiliarDesignados();
        }

        public IActionResult OnPost(Paciente paciente){
            try{
                repositorioPaciente.addPaciente(paciente);
                return RedirectToPage("./ListPaciente");
            }catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
