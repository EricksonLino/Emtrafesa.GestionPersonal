using Emtrafesa.GestionPersonal.Application.Implementacion;
using Emtrafesa.GestionPersonal.Application.Interfaces;
using Emtrafesa.GestionPersonal.Application.Profiles;
using Emtrafesa.GestionPersonal.Repository;
using Emtrafesa.GestionPersonal.Repository.Implementacion;
using Emtrafesa.GestionPersonal.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(conf => 
                conf.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IChoferRepository, ChoferRepository>();
builder.Services.AddScoped<IChoferApplication, ChoferApplication>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
