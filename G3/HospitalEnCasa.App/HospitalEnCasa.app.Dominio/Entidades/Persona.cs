using System;

namespace HospitalEnCasa.app.Dominio
{
    public class Persona{

        public int Id { get; set; }
        public int cedula { get; set; }
        public string nombre{ get;set;}
        public int edad{get; set;}
        public Genero genero{ get; set; }
    }
}