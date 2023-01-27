using OcazAPI.Services.OffreAPI.offreDbContexts;
using OcazAPI.Services.OffreAPI.Repository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OcazAPI.Services.OffreAPI;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<OffreDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));










IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());













builder.Services.AddScoped<IOffreRepository, OffreRepository>();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
