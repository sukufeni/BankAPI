using BankAPI.Services.Impl;
using BankAPI.Services.Int;
using BankDAO;
using BankDAO.Imp;
using BankDAO.Int;
using BankDomain;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ContextPrincipal>(context => context.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IContaRepository, ContaRepository>();
builder.Services.AddScoped<IGerenteRepository, GerenteRepository>();
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IGerenteService, GerenteService>();
builder.Services.AddScoped<IContaService, ContaService>();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
