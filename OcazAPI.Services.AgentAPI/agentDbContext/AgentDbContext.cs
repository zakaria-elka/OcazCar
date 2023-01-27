using Microsoft.EntityFrameworkCore;
using OcazAPI.Services.AgentAPI.Models;

namespace OcazAPI.Services.AgentAPI.agentDbContext
{
    public class AgentDbContext : DbContext
    {
        public AgentDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Agent> Agents { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);





            modelBuilder.Entity<Agent>().HasData(new Agent
            {
                AgentId = 1,
                AgentName = "AZIZ",
                AgentPhone = "0633445566",
                AgentPas ="1234"

            });
            modelBuilder.Entity<Agent>().HasData(new Agent
            {
                AgentId = 2,
                AgentName = "Ahmed",
                AgentPhone = "0633445588",
                AgentPas="1234"

            });
            modelBuilder.Entity<Agent>().HasData(new Agent
            {
                AgentId = 3,
                AgentName = "Said",
                AgentPhone = "0633445577",
                AgentPas="1234"

            });

        }




    }
}
