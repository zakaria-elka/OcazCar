// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OcazAPI.Services.AgentAPI.agentDbContext;

#nullable disable

namespace OcazAPI.Services.AgentAPI.Migrations
{
    [DbContext(typeof(AgentDbContext))]
    [Migration("20230126142242_Agent")]
    partial class Agent
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OcazAPI.Services.AgentAPI.Models.Agent", b =>
                {
                    b.Property<int>("AgentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AgentId"));

                    b.Property<string>("AgentName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("AgentPas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AgentPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AgentId");

                    b.ToTable("Agents");

                    b.HasData(
                        new
                        {
                            AgentId = 1,
                            AgentName = "AZIZ",
                            AgentPas = "1234",
                            AgentPhone = "0633445566"
                        },
                        new
                        {
                            AgentId = 2,
                            AgentName = "Ahmed",
                            AgentPas = "1234",
                            AgentPhone = "0633445588"
                        },
                        new
                        {
                            AgentId = 3,
                            AgentName = "Said",
                            AgentPas = "1234",
                            AgentPhone = "0633445577"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
