# CRM Pyme - Sistema de Gestión de Relaciones con Clientes

## Descripción del Proyecto

CRM Pyme es una aplicación web desarrollada en ASP.NET Core MVC que busca proporcionar una solución integral para la gestión de relaciones con clientes en pequeñas y medianas empresas. El proyecto está diseñado con una arquitectura moderna utilizando Entity Framework Core para el acceso a datos, PostgreSQL como base de datos, y ASP.NET Core Identity para la gestión de autenticación y autorización. La aplicación implementa un sistema de roles (Administrador y Vendedor) que permite diferentes niveles de acceso y funcionalidades según el tipo de usuario.

El objetivo principal es crear una herramienta intuitiva y escalable que permita a las pymes gestionar eficientemente sus clientes, seguimientos de ventas, y reportes básicos. La aplicación está construida con un enfoque en la simplicidad de uso, manteniendo la robustez necesaria para un entorno empresarial, y está preparada para crecer con las necesidades específicas de cada negocio.

## Funcionalidades Básicas

### Implementadas:
- ✅ Sistema de autenticación y autorización con roles
- ✅ Interfaz básica con navegación entre vistas
- ✅ Estructura MVC con controladores y vistas
- ✅ Configuración de base de datos PostgreSQL
- ✅ Layout responsive con Bootstrap

### En Desarrollo/Próximas Funcionalidades:
- 🔄 Gestión de clientes (CRUD básico)
- 🔄 Seguimiento de oportunidades de venta
- 🔄 Dashboard con métricas básicas
- 🔄 Sistema de notificaciones simples
- 🔄 Reportes básicos de ventas
- 🔄 Gestión de productos/servicios
- 🔄 Calendario de actividades
- 🔄 Exportación de datos a Excel/PDF

## Tecnologías Utilizadas

- **Backend**: ASP.NET Core 9.0, C#
- **Frontend**: HTML, CSS, Bootstrap, Razor
- **Base de Datos**: PostgreSQL
- **ORM**: Entity Framework Core
- **Autenticación**: ASP.NET Core Identity
- **Herramientas**: Visual Studio Code, Git

## Instalación y Configuración

1. Clona el repositorio
2. Configura la cadena de conexión en `appsettings.json`
3. Ejecuta las migraciones: `dotnet ef database update`
4. Ejecuta la aplicación: `dotnet run`

## Licencia

Este proyecto está bajo la licencia MIT con requisitos adicionales de atribución. Esto significa que puedes:

- ✅ **Forkear** el proyecto libremente
- ✅ **Modificar** el código según tus necesidades
- ✅ **Usar** en proyectos comerciales
- ✅ **Distribuir** copias del software

**📋 Requisito de Atribución:**
Si haces fork, modificas o distribuyes este software, debes incluir:

- Mencionar al autor original: **"Aaron Newball"**
- Enlace al repositorio original: **"https://github.com/a-nxwball/CrmPymeApp"**
- Incluir este archivo de licencia en tu proyecto
- Agregar una nota en tu README.md reconociendo el trabajo original

**Ejemplo de atribución requerida:**
```
This project is based on CRM Pyme by Aaron Newball (https://github.com/a-nxwball/CrmPymeApp)
```

Para más detalles, consulta el archivo [LICENSE](LICENSE).

## Contribuciones y Sugerencias

¡Este es un proyecto en desarrollo y estoy abierto a sugerencias y contribuciones! Si tienes ideas para mejorar la aplicación, nuevas funcionalidades que podrían ser útiles, o mejoras en el código, no dudes en:

- **💬 Únete a las [Discusiones](https://github.com/a-nxwball/CrmPymeApp/discussions)** - Comparte ideas, haz preguntas y conecta con la comunidad
- Abrir un issue con tu sugerencia
- Crear un pull request con mejoras
- Compartir tu experiencia con CRMs similares

Especialmente agradezco sugerencias sobre:
- Funcionalidades que faltan para un CRM básico
- Mejoras en la experiencia de usuario
- Optimizaciones de rendimiento
- Mejores prácticas de desarrollo

**🎯 ¿No sabes por dónde empezar?** ¡Visita mis [Discusiones](https://github.com/a-nxwball/CrmPymeApp/discussions) y únete a la conversación! Es el lugar perfecto para compartir ideas, hacer preguntas y conocer a otros desarrolladores interesados en CRMs.

## Estado del Proyecto

🚧 **En desarrollo activo** - Este es un proyecto de aprendizaje y desarrollo continuo. Las funcionalidades se van agregando progresivamente según las necesidades identificadas.

---

*Desarrollado con ❤️ para la comunidad de desarrolladores junior* 