using System;
using System.Collections.Generic;
using System.Linq;
using HospitalEnCasa.app.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HospitalEnCasa.app.Persistencia{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        private readonly Contexto _contexto;

        public RepositorioHistoria(Contexto contexto){
            this._contexto = contexto;
        }
        public Historia addHistoria(Historia historia)
        {
            return _contexto.Add(historia).Entity;
        }

        public Historia editHistoria(Historia historia)
        {
            Historia historiaAEditar = _contexto.historias.FirstOrDefault(p => p.Id == historia.Id);
            if(historiaAEditar != null){
                historiaAEditar.anotacion = historia.anotacion;
                historiaAEditar.fecha = historia.fecha;
                _contexto.SaveChanges();

            }
            return historiaAEditar;
        }

        public IEnumerable<Historia> geAllHistoria()
        {
            return _contexto.historias;
        }

        public Historia getHistoria(int id)
        {
            return _contexto.historias.FirstOrDefault(h => h.Id == id);
        }

        public IEnumerable<Historia> historiaPorEnfermera(Enfermera enfermera)
        {
            throw new NotImplementedException();
            
            

            
        }

        public IEnumerable<Historia> historiaPorFechaYPaciente(DateTime fecha_inicio, DateTime fecha_final, Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Historia> historiaPorMedico(Medico medico)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Historia> historiaPorPaciente(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public void RemoveHistoria(int id)
        {
            Historia historiaAEliminar = _contexto.historias.FirstOrDefault(p => p.Id == id);
            if(historiaAEliminar != null){
                _contexto.historias.Remove(historiaAEliminar);
                _contexto.SaveChanges();
            }
        }
    }
}