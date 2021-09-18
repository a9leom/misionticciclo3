using System.Collections.Generic;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia{
    public interface IRepositorioPersona{
        Persona addPersona(Persona persona);
        void removePersona(int cedula);
        IEnumerable<Persona> obtenerPersonas();
        Persona editarPersona(Persona persona);
    }
}