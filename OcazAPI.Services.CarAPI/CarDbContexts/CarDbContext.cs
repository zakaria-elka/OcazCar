using Microsoft.EntityFrameworkCore;
using OcazAPI.Services.CarAPI.Models;

namespace OcazAPI.Services.CarAPI.CarDbContexts
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Cars> Cars { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<Cars>().HasData(new Cars
            {
                CarId = 1,
                CarName = "Bwm Serie3",
                CarModel = "2012",
                CarTrans = "Automatique",
                CarCarburant = "Essence",
                CarKm = "100 000km",
                CarDesc = "4cylindre 2l avec 200hp 320Nm",
                CarImage = new byte[0],


            });
            modelBuilder.Entity<Cars>().HasData(new Cars
            {
                CarId = 2,
                CarName = "Toyota corolla",
                CarModel = "2015",
                CarTrans = "Manuel",
                CarCarburant = "Diesel",
                CarKm = "120 000km",
                CarDesc = "4cylindre 1.2l avec 120hp 300Nm",
                CarImage = new byte[0] ,
            });
            modelBuilder.Entity<Cars>().HasData(new Cars
            {
                CarId = 3,
                CarName = "Hyundai tucson",
                CarModel = "2016",
                CarTrans = "Manuel",
                CarCarburant = "Diesel",
                CarKm = "95 520km",
                CarDesc = "4cylindre 1.6l avec 160hp 320Nm",
                CarImage = new byte[0],

            });

        }

    }
}
