using RestDocentesAPI.Data.Repositories;
using RestDocentesAPI.Data;
using RestDocentesAPI.Extensions;
using RestDocentesAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// DbContexts
builder.Services.AddDbContext<DocentesContext>();
// Repositories and services
builder.Services.AddScoped<IDocentesRepository, DocentesRepository>();
builder.Services.AddScoped<IDocentesService, DocentesService>();


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

app.EnsureDbCreated();


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
