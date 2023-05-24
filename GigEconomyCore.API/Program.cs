using GigEconomyCore.Domain.Handler;
using GigEconomyCore.Domain.IRepository;
using GigEconomyCore.Infra.Context;
using GigEconomyCore.Infra.Repository;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("GigEconomyConnectionString")));

builder.Services.AddScoped<PartnerHandler>();
builder.Services.AddScoped<IPartnerRepository, PartnerRepository>();

builder.Services.AddScoped<AssistanceHandler>();
builder.Services.AddScoped<IAssistanceRepository, AssistanceRepository>();

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
