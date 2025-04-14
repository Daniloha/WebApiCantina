using Microsoft.EntityFrameworkCore;
using WebApiCantina.Api.Extensions;
using WebApiCantina.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Configuração de serviços
builder.Services.AddApplicationServices(builder.Configuration);

var app = builder.Build();//Instancia da aplicação WEB

// Configuração do pipeline de requisição
app.UseApplicationConfiguration();

app.Run();// Middleware final -> Ponta da request.

