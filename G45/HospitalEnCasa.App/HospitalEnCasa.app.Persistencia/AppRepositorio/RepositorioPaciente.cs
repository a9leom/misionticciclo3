using System.Collections.Generic;
using System.Linq;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly Contexto _contexto;
        public RepositorioPaciente(Contexto contexto){
            _contexto = contexto;
        }
        public Paciente agregarPaciente(Paciente paciente)
        {
            Paciente pacienteAgregado = _contexto.Add(paciente).Entity;
            _contexto.SaveChanges();
            return pacienteAgregado;
        }

        public Paciente editarPaciente(Paciente paciente)
        {
            Paciente pacienteAEditar = _contexto.Pacientes.FirstOrDefault(c => c.Id == paciente.Id);
            if(pacienteAEditar!=null){
                pacienteAEditar.cedula = paciente.cedula;
                pacienteAEditar.edad = paciente.edad;
                pacienteAEditar.genero = paciente.genero;
                pacienteAEditar.latitud = paciente.latitud;
                pacienteAEditar.longitud = paciente.longitud;
                pacienteAEditar.medico_asignado = paciente.medico_asignado;
                pacienteAEditar.nombre = paciente.nombre;
                _contexto.SaveChanges();
            }
            return pacienteAEditar;
        }

        public void eliminarPaciente(int cedula)
        {
            Paciente pacienteAEliminar = _contexto.Pacientes.FirstOrDefault(c => c.cedula == cedula);
            if (pacienteAEliminar != null){
                _contexto.Pacientes.Remove(pacienteAEliminar);
                _contexto.SaveChanges();
            }
            
        }

        public Paciente obtenerPaciente(int cedula)
        {
            Paciente pacienteEncontrado = _contexto.Pacientes.FirstOrDefault(c => c.cedula == cedula);
            return pacienteEncontrado;
        }

        public IEnumerable<Paciente> obtenerPacientes()
        {
            return _contexto.Pacientes;
        }
    }
}