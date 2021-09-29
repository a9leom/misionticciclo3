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

    public class AddAnotacionModel : PageModel
    {
        private readonly IRepositorioAnotacion repositorioAnotacion;
        private readonly IRepositorioMedico repositorioMedico;
        private readonly IRepositorioEnfermera repositorioEnfermera;
        private readonly IRepositorioPaciente repositorioPaciente;

        public IEnumerable<SelectListItem> medicos { get; set; }
        public IEnumerable<SelectListItem> enfermeras { get; set; }
        public IEnumerable<SelectListItem> pacientes { get; set;}

        public Anotacion anotacion { get; set; }
        public int cedulaMedico { get; set; }
        public int cedulaEnfermera { get; set; }
        public int cedulaPaciente { get; set; }

        public AddAnotacionModel(IRepositorioAnotacion repositorioAnotacion, IRepositorioMedico repositorioMedico,IRepositorioPaciente repositorioPaciente,IRepositorioEnfermera repositorioEnfermera){
            this.repositorioAnotacion = repositorioAnotacion;
            this.repositorioMedico = repositorioMedico;
            this.repositorioEnfermera = repositorioEnfermera;
            this.repositorioPaciente = repositorioPaciente;

            medicos = repositorioMedico.getAllMedicos().Select(
                m => new SelectListItem{
                    Value = Convert.ToString(m.cedula),
                    Text = m.nombre
                }
            );
            pacientes = repositorioPaciente.getAllPacientes().Select(
                m => new SelectListItem{
                    Value = Convert.ToString(m.cedula),
                    Text = m.nombre
                }
            );
            enfermeras = repositorioEnfermera.getAllEnfermeras().Select(
                m => new SelectListItem{
                    Value = Convert.ToString(m.cedula),
                    Text = m.nombre
                }
            );

            anotacion = new Anotacion();
        }
        public void OnGet()
        {
        } 

        public IActionResult OnPost(Anotacion anotacion,int cedulaMedico,int cedulaEnfermera,int cedulaPaciente){
            if(ModelState.IsValid){
                repositorioAnotacion.addAnotacion(anotacion);

                Medico medico = repositorioMedico.getMedico(cedulaMedico);
                Enfermera enfermera = repositorioEnfermera.getEnfermera(cedulaEnfermera);
                Paciente paciente = repositorioPaciente.getPaciente(cedulaPaciente);

                anotacion.medico = medico;
                anotacion.enfermera = enfermera;
                anotacion.paciente = paciente;

                repositorioAnotacion.editAnotacion(anotacion);

                return RedirectToPage("./ListAnotacion");
            }
            else{
                return Page();
            }
        }
    }
}
