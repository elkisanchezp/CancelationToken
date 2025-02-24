🚀 CancellationToken en .NET Core

Este proyecto demuestra cómo implementar y utilizar CancellationToken en una aplicación ASP.NET Core para cancelar tareas de larga duración de manera controlada.

📦 Requisitos

.NET Core 8.0 o superior

Visual Studio, VS Code o cualquier editor compatible

⚙️ Instalación

Clonar el repositorio:

git clone https://github.com/tu_usuario/proyecto-cancellation-token.git

Navegar al directorio del proyecto:

cd proyecto-cancellation-token

Restaurar dependencias:

dotnet restore

Compilar el proyecto:

dotnet build

📝 Descripción del Proyecto

Este proyecto incluye un controlador de API con un endpoint que simula un proceso largo y permite cancelarlo usando un CancellationToken. El objetivo es evitar el consumo innecesario de recursos cuando el cliente cancela la solicitud.

🚀 Ejecución del Proyecto

Iniciar la aplicación:

dotnet run

Probar el endpoint de ejemplo:

curl -X GET "https://localhost:5001/api/tarea-larga" -v

Para cancelar la solicitud, presiona Ctrl + C o configura un timeout desde el cliente.

🛠️ Ejemplo de Código

[ApiController]
[Route("api/[controller]")]
public class TareaLargaController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        try
        {
            Console.WriteLine("Proceso iniciado...");
            await Task.Delay(10000, cancellationToken);
            return Ok("Proceso completado.");
        }
        catch (OperationCanceledException)
        {
            return StatusCode(499, "La operación fue cancelada por el cliente.");
        }
    }
}

✅ Pruebas

Ejecutar las pruebas unitarias:

dotnet test

📜 Licencia

Este proyecto está licenciado bajo la licencia MIT. Puedes usarlo, modificarlo y distribuirlo libremente.

🤝 Contribuciones

¡Las contribuciones son bienvenidas! Si deseas mejorar el proyecto, crea un Pull Request o abre un Issue.

Autor: Elkin SánchezRepositorio: GitHubFecha: Agosto 2024
