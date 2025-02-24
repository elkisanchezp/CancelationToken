# CancellationToken Project

Este proyecto demuestra el uso de `CancellationToken` en .NET para manejar la cancelación de tareas.

## 🛠️ Requisitos
- .NET Core 8.0
- Visual Studio 2022 o superior

## 🚀 Ejecución del Proyecto
1. Clonar el repositorio:
```bash
git clone https://github.com/elkisanchezp/CancelationToken.git
```
2. Navegar al directorio del proyecto:
```bash
cd ExampleCancelationToken
```
3. Restaurar paquetes y ejecutar:
```bash
dotnet restore
dotnet run
```

## 📄 Importante
En este ejemplo, el tiempo de respuesta del método es de 10 segundos, simulando una consulta pesada

```csharp
 public async Task<IEnumerable<User>> GetAllUsersAsync(CancellationToken cancellationToken)
 {
     // Simulation
     await Task.Delay(10000, cancellationToken);
     return await _context.Users.ToListAsync(cancellationToken);
 }
```

