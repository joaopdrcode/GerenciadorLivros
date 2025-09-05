using GerenciadorLivrosBackend.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// registro do DbContext 
builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("Livros"));

// registro dos repositorios
builder.Services.AddScoped<IGetLivroRepository, GetLivroRepository>();
builder.Services.AddScoped<IGetLivrosRepository, GetLivrosRepository>();
builder.Services.AddScoped<IDeleteLivroRepository, DeleteLivroRepository>();
builder.Services.AddScoped<IInsertLivroRepository, InsertLivroRepository>();
builder.Services.AddScoped<IUpdateLivroRepository, UpdateLivroRepository>();

// registro do service
builder.Services.AddScoped<ApiResponseService>();

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
