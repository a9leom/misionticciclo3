using System.Collections.Generic;
using System.Linq;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia{
    public class RepositorioFamiliar : IRepositorioFamiliar
    {
        private readonly Contexto _contexto;
        public RepositorioFamiliar(Contexto context){
            this._contexto = context;
        }
        public Familiar addFamiliar(Familiar familiar)
        {
            Familiar familiarNuevo = _contexto.Add(familiar).Entity;
            _contexto.SaveChanges();
            return familiarNuevo;
        }

        public Familiar editFamiliar(Familiar familiar)
        {
            Familiar familiarEncontrado =  _contexto.Familiares.FirstOrDefault(f => f.Id == familiar.Id);
            if(familiarEncontrado != null){
                familiarEncontrado.cedula = familiar.cedula;
                familiarEncontrado.nombre = familiar.nombre;
                familiarEncontrado.edad = familiar.edad;
                familiarEncontrado.genero = familiar.genero;
                familiarEncontrado.direccion =  familiar.direccion;
                familiarEncontrado.longitud = familiar.longitud;
                familiarEncontrado.latitud = familiar.latitud;
                _contexto.SaveChanges();
            }
            return familiarEncontrado;
        }

        public IEnumerable<Familiar> getAllFamiliares()
        {
            return _contexto.Familiares;
        }

        public Familiar getFamiliar(int cedula)
        {
            return _contexto.Familiares.FirstOrDefault(p => p.cedula == cedula);
        }

        public void RemoveFamiliar(Familiar familiar)
        {
            Familiar familiarEncontrado =  _contexto.Familiares.FirstOrDefault(f => f.Id == familiar.Id);
            if(familiarEncontrado != null){        
                _contexto.Familiares.Remove(familiarEncontrado);
                _contexto.SaveChanges();
            }
        }
    }
}