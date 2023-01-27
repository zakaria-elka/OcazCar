using Microsoft.EntityFrameworkCore;
using OcazAPI.Services.OffreAPI.Models;


namespace OcazAPI.Services.OffreAPI.offreDbContexts
{
    public class OffreDbContext : DbContext
    {
        public OffreDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Offre> Offres { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Offre>().HasData(new Offre
            {
                OffreId = 1,
                OffreCarName = "Bwm Serie3 2012",
                Price = 150000,
                DatePub = "12 janvier 2022",
                Ville = "Rabat",
                AgentId = 1,
                CarId = 1
            });
            modelBuilder.Entity<Offre>().HasData(new Offre
            {
                OffreId = 2,
                OffreCarName = "Toyota corolla 2015",
                Price = 100000,
                DatePub = "13 fevrier 2022 ",
                Ville = "Casablanca",
                AgentId = 2,
                CarId = 2

            });
            modelBuilder.Entity<Offre>().HasData(new Offre
            {
                OffreId = 3,
                OffreCarName = "Hyundai tucson 2016",
                Price = 170000,
                DatePub = "20 septembre 2022 ",
                Ville = "Oujda",
                AgentId = 3,
                CarId = 3
            });


        }

    }
}
