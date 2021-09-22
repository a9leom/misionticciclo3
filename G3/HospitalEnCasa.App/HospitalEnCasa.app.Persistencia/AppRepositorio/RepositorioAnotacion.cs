using System.Collections.Generic;
using System.Linq;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia{
    public class RepositorioAnotacion : IRepositorioAnotacion
    {
        private readonly Contexto _contexto;
        public RepositorioAnotacion(Contexto context){
            this._contexto = context;
        }
        public Anotacion addAnotacion(Anotacion anotacion)
        {
            Anotacion anotacionNew = _contexto.Add(anotacion).Entity;
            return anotacionNew;
        }

        public Anotacion editAnotacion(Anotacion anotacion)
        {
            Anotacion anotacionAEditar = _contexto.anotaciones.FirstOrDefault(a => a.Id == anotacion.Id);
            if(anotacionAEditar != null){
                anotacionAEditar.descripcion = anotacion.descripcion;
                anotacionAEditar.enfermera = anotacion.enfermera;
                anotacionAEditar.medico = anotacion.medico;
                anotacionAEditar.paciente = anotacion.paciente;
                anotacionAEditar.formula_medica = anotacion.formula_medica;
                _contexto.SaveChanges();
            }
            return anotacionAEditar;
        }

        public IEnumerable<Anotacion> getAllAnotacion()
        {
            return _contexto.anotaciones;
        }

        public Anotacion getAnotacionById(int id)
        {
            return _contexto.anotaciones.FirstOrDefault(a => a.Id == id);
        }

        public void removeAnotacion(int id)
        {
            Anotacion anotacion = _contexto.anotaciones.FirstOrDefault(a => a.Id == id);
            if(anotacion != null){
                _contexto.anotaciones.Remove(anotacion);
                _contexto.SaveChanges();
            }
        }
    }
}