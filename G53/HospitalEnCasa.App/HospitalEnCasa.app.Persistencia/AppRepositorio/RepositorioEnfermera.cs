using System.Collections.Generic;
using System.Linq;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia{
    public class RepositorioEnfermera : IRepositorioEnfermera
    {
        private readonly Contexto _contexto;

        public RepositorioEnfermera(Contexto context){
            this._contexto = context;
        }
        public Enfermera addEnfermera(Enfermera enfermera)
        {
            Enfermera enfermeraNueva = _contexto.Add(enfermera).Entity;
            _contexto.SaveChanges();
            return enfermeraNueva;
        }

        public Enfermera editEnfermera(Enfermera enfermera)
        {
            Enfermera enfermeraEncontrada = _contexto.Enfermeras.FirstOrDefault(e => e.cedula == enfermera.cedula);

            if(enfermeraEncontrada != null){
                enfermeraEncontrada.cedula = enfermera.cedula;
                enfermeraEncontrada.nombre = enfermera.nombre;
                enfermeraEncontrada.edad = enfermera.edad;
                enfermeraEncontrada.genero = enfermera.genero;
                enfermeraEncontrada.informacion_laboral=enfermera.informacion_laboral;
                enfermeraEncontrada.hospital = enfermera.hospital;
                _contexto.SaveChanges();
            }
            return enfermeraEncontrada;
        }

        public Enfermera getEnfermera(int cedula)
        {
            Enfermera enfermera = _contexto.Enfermeras.FirstOrDefault(e => e.cedula == cedula);
            return enfermera;
        }

        public IEnumerable<Enfermera> getEnfermeras()
        {
            return _contexto.Enfermeras;
        }

        public void removeEnfermera(int cedula)
        {
            Enfermera enfermera = _contexto.Enfermeras.FirstOrDefault(e => e.cedula == cedula);
            if(enfermera != null){
                _contexto.Enfermeras.Remove(enfermera);
                _contexto.SaveChanges();
            }
            
        }
    }
}