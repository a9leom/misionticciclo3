using Microsoft.EntityFrameworkCore;
using TicketMetro.App.Dominio;

namespace TicketMetro.App.Persistencia{

    public class Contexto : DbContext {
        public DbSet<Persona> Personas {get; set; }
        public DbSet<Estacion> Estaciones {get; set; }
        public DbSet<Ticket> Tickets {get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opciones) {
            if(!opciones.IsConfigured){
                opciones.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=MetroBogota");
            }
        }

    }
}