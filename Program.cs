using Proyecto.Domain.Configuration;
using Proyecto.Infrastructure; // Importante para ver el método AddInfrastructure

var builder = WebApplication.CreateBuilder(args);

// 1. Vincular appsettings.json con la clase MediaSettings
builder.Services.Configure<MediaSettings>(
    builder.Configuration.GetSection(MediaSettings.SectionName));

// 2. Inyectar los servicios de la capa de Infraestructura
builder.Services.AddInfrastructure();

builder.Services.AddControllers();
// ... resto del código (Swagger, etc)

var app = builder.Build();
app.MapControllers();
app.Run();