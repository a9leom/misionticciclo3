using System.Collections.Generic;
using System.Linq;
using HospitalEnCasa.app.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HospitalEnCasa.app.Persistencia{
    public class RepositorioCita : IRepositorioCita
    {
        private readonly Contexto _contexto;

        public RepositorioCita(Contexto contexto){
            this._contexto = contexto;
        }
        public Cita addCita(Cita cita)
        {
            Cita citacruzada = _contexto.Citas.FirstOrDefault(c=> c.dia == cita.dia && c.hora == cita.hora && c.medico.Id == cita.medico.Id );

            if(citacruzada == null){
                _contexto.Citas.Add(cita);
                _contexto.SaveChanges();
                return cita;
            }
            else{
                return null;
            }
        }

        public IEnumerable<Cita> getAllCitas()
        {
            return _contexto.Citas.Include("paciente").Include("medico");;
        }
    }
}