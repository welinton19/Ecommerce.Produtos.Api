using Scalar.AspNetCore;
using Ecommerce.Produtos.Infrastructure.Dependecy_Injection;
using Ecommerce.Produtos.Application.Services;
using Ecommerce.Produtos.Application.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddOpenApi();



//Inject dependencies
builder.Services.AddInfrastructure(builder.Configuration);
// service
builder.Services.AddScoped<ICategoriaService, CategoriaService>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();

builder.AddServiceDefaults();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();
app.MapScalarApiReference();

app.UseHttpsRedirection();


app.MapControllers();


app.Run();


