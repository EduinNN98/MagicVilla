using MagicVilla_APICURSO.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_APICURSO.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre = "Villa Paraiso",
                    Detalle = "Detalle Paraiso",
                    ImagenUrl = " ",
                    Ocupantes = 5,
                    MetrosCuadrados = 255,
                    Tarifa = 300,
                    Amenidad = " ",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                },
                 new Villa()
                 {
                     Id = 2,
                     Nombre = "Villa Selva",
                     Detalle = "Detalle Selva",
                     ImagenUrl = " ",
                     Ocupantes = 2,
                     MetrosCuadrados = 255,
                     Tarifa = 350,
                     Amenidad = " ",
                     FechaCreacion = DateTime.Now,
                     FechaActualizacion = DateTime.Now
                 },
                  new Villa()
                  {
                      Id = 3,
                      Nombre = "Villa Tropical",
                      Detalle = "Detalle Tropical",
                      ImagenUrl = " ",
                      Ocupantes = 6,
                      MetrosCuadrados = 500,
                      Tarifa = 850,
                      Amenidad = " ",
                      FechaCreacion = DateTime.Now,
                      FechaActualizacion = DateTime.Now
                  }

            ); ;
        }
    }
}
