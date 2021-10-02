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
    public class AddAnotacionModel : PageModel
    {
        private readonly IRepositorioAnotacion repositorioAnotacion;
        private readonly IRepositorioSignoVital repositorioSignoVital;
        private readonly IRepositorioMedico repositorioMedico;
        private readonly IRepositorioEnfermera repositorioEnfermera;
        private readonly IRepositorioPaciente repositorioPaciente;
        public SignoVital signosVital{ get; set;}
        public Anotacion anotacion{get; set;}

        public IEnumerable<SelectListItem> medicos { get; set; }
        public IEnumerable<SelectListItem> enfermeras { get; set; }
        public IEnumerable<SelectListItem> pacientes { get; set; }

        public int cedulaMedico { get; set; }
        public int cedulaEnfermera { get; set; }
        public int cedulaPaciente{get; set; }

        public AddAnotacionModel(IRepositorioAnotacion repositorioAnotacion, IRepositorioSignoVital sign, IRepositorioMedico repositorioMedico,IRepositorioEnfermera repositorioEnfermera, IRepositorioPaciente repositorioPaciente){
            this.repositorioAnotacion = repositorioAnotacion;
            this.repositorioSignoVital = sign;
            this.repositorioMedico = repositorioMedico;
            this.repositorioEnfermera = repositorioEnfermera;
            this.repositorioPaciente = repositorioPaciente;
            signosVital = new SignoVital();
            anotacion = new Anotacion();

            generarListas();

        }

        public void generarListas(){
            medicos = repositorioMedico.getMedicos().Select(
                m => new SelectListItem(){
                    Text = m.nombre,
                    Value = Convert.ToString(m.cedula)
                }
            );

            enfermeras = repositorioEnfermera.getAllEnfermeras().Select(
                f => new SelectListItem(){
                    Text = Convert.ToString(f.cedula)+" "+f.nombre,
                    Value = Convert.ToString(f.cedula)
                }
            );

            pacientes = repositorioPaciente.obtenerPacientes().Select(
                p => new SelectListItem(){
                    Text = p.nombre+" "+p.direccion,
                    Value = Convert.ToString(p.cedula)
                }
            );


        }
        public void OnGet()
        {
        }
    }
}
