using System.Collections.Generic;
using System.Linq;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly Contexto _contexto;
        public RepositorioPaciente(Contexto contexto){
            this._contexto = contexto;
        }
        public Paciente addPaciente(Paciente paciente)
        {
            Paciente pacienteNuevo = _contexto.Add(paciente).Entity;
            _contexto.SaveChanges();
            return pacienteNuevo;
        }

        public Paciente editPaciente(Paciente paciente)
        {
            Paciente pacienteAEditar = _contexto.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            if(pacienteAEditar != null){
                pacienteAEditar.cedula = paciente.cedula;
                pacienteAEditar.nombre = paciente.nombre;
                pacienteAEditar.edad = paciente.edad;
                pacienteAEditar.genero = paciente.genero;
                pacienteAEditar.direccion=paciente.direccion;
                pacienteAEditar.latitud = paciente.latitud;
                pacienteAEditar.longitud = paciente.longitud;
                pacienteAEditar.familiar = paciente.familiar;
                pacienteAEditar.enfermera = paciente.enfermera;
                pacienteAEditar.medico = paciente.medico;
                _contexto.SaveChanges();
            }
            return pacienteAEditar;
        }

        public IEnumerable<Paciente> getAllPacientes()
        {
            return _contexto.Pacientes;
        }

        public Paciente getPaciente(int cedula)
        {
            return _contexto.Pacientes.FirstOrDefault(p => p.cedula == cedula);
        }

        public void RemovePaciente(int cedula)
        {
            Paciente pacienteAEliminar = _contexto.Pacientes.FirstOrDefault(p => p.cedula == cedula);
            if(pacienteAEliminar != null){
                _contexto.Pacientes.Remove(pacienteAEliminar);
                _contexto.SaveChanges();
            }
        }
    }
}