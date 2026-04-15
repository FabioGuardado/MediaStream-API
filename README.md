# Multimedia Stream API

Esta es una API robusta y escalable desarrollada en C# para la gestión y reproducción de contenido multimedia. El proyecto ha sido diseñado siguiendo los principios de Clean Architecture, lo que permite una separación de responsabilidades clara y facilita su crecimiento para ser consumido por aplicaciones web modernas.

# 🏗️ Arquitectura

El proyecto se divide en las siguientes capas para asegurar la mantenibilidad y desacoplamiento:

- **Domain:** Contiene las entidades, interfaces de repositorios y lógica de negocio central (reglas de dominio). No tiene dependencias externas.
- **Application:** Implementa los casos de uso del sistema. Orquestador de la lógica de negocio y definiciones de DTOs.
- **Infrastructure:** Implementa el acceso a datos, servicios externos (como almacenamiento de archivos multimedia) y otras herramientas de terceros.
- **API / Presentation:** Punto de entrada de la aplicación que expone los endpoints REST para ser consumidos por el frontend.

# 🚀 Tecnologías Principales

- **Lenguaje:** C#
- **Framework:** .NET 10.0
- **Persistencia:** Entity Framework Core (SQL Server)
- **Documentación:** OpenAPI

# 🛠️ Instalación y Configuración

1. **Clonar el repositorio:**

```bash
git clone https://github.com/ayorick23/MediaStream-API
```
  
2. **Configurar la base de datos (carpeta):** Actualiza la cadena de conexión en el archivo ``appsettings.json`` dentro del proyecto de la API.
3. **Ejecutar migraciones (pendiente):**

```bash
dotnet ef database update --project Infrastructure --startup-project API
```

4. **Iniciar la aplicación:**

```bash
dotent run --project API
```

# 🛣️ Roadmap / Próximos Pasos

- [ ] Implementar autenticación y autorización con JWT.
- [ ] Integración con proveedores de almacenamiento en la nube (AWS S3 / Azure Blob Storage).
- [ ] Implementar transcodificación de video en segundo plano.
- [ ] Desarrollo de cliente web para consumo de la API.
