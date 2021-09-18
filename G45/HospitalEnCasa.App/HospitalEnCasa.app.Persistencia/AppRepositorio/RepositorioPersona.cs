using System.Collections.Generic;
using System.Linq;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia{
    public class RepositorioPersona : IRepositorioPersona
    {

        private readonly Contexto _contexto;
        public RepositorioPersona(Contexto contexto){
            _contexto = contexto;
        }
        public Persona addPersona(Persona persona)
        {
            var personaIng = _contexto.Add(persona).Entity;
            _contexto.SaveChanges();
            return personaIng;
            
        }

        public Persona editarPersona(Persona persona)
        {
            var personaEditada = _contexto.Personas.Where(p => p.Id == persona.Id).FirstOrDefault();
            if(personaEditada != null){
                personaEditada.nombre = persona.nombre;
                personaEditada.cedula = persona.cedula;
                personaEditada.edad = persona.edad;
                personaEditada.genero = persona.genero;
                _contexto.SaveChanges();
            }
            return personaEditada;
        }

        public IEnumerable<Persona> obtenerPersonas()
        {
            return _contexto.Personas;
        }

        public void removePersona(int cedula)
        {
            var personaEliminada = _contexto.Personas.Where(p => p.cedula == cedula).FirstOrDefault();
            if(personaEliminada != null){
                _contexto.Personas.Remove(personaEliminada);
                _contexto.SaveChanges();
            }
        }
    }
}