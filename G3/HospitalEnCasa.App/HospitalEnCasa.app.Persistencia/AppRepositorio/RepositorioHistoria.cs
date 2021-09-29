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
            Historia historiaNueva =  _contexto.Add(historia).Entity;
            _contexto.SaveChanges();
            return historiaNueva;
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
            return _contexto.historias.Include("anotacion").Include("anotacion.paciente").Include("anotacion.medico").Include("anotacion.enfermera");
        }

        public Historia getHistoria(int id)
        {
            return _contexto.historias.Include("anotacion").FirstOrDefault(h => h.Id == id);
        }

        public IEnumerable<Historia> historiaPorEnfermera(Enfermera enfermera)
        {
            IEnumerable<Historia> historias = _contexto.historias.Where(h => h.anotacion.enfermera.Id == enfermera.Id).Include("anotacionId");
            return historias;  
        }

        public IEnumerable<Historia> historiaPorFechaYPaciente(DateTime fecha_inicio, DateTime fecha_final, Paciente paciente)
        {
            IEnumerable<Historia> historias = _contexto.historias.Where(h => h.fecha >= fecha_inicio & h.fecha <= fecha_final & h.anotacion.paciente.Id >= paciente.Id).Include("anotacionId");      
            return historias;  
        }

        public IEnumerable<Historia> historiaPorMedico(Medico medico)
        {
            IEnumerable<Historia> historias = _contexto.historias.Where(h => h.anotacion.medico.Id == medico.Id).Include("anotacionId");
            return historias;
        }

        public IEnumerable<Historia> historiaPorPaciente(Paciente paciente)
        {
            IEnumerable<Historia> historias = _contexto.historias.Where(h => h.anotacion.paciente.Id == paciente.Id).Include("anotacionId");
            return historias;
            
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