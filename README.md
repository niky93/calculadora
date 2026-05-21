# Calculadora

Aplicacion de consola en .NET 8 para la actividad practica de DevOps. Implementa una calculadora sencilla y pruebas unitarias con MSTest.

## Estructura del proyecto

- `Calculadora.csproj`: aplicacion principal.
- `Calculator.cs`: logica de la calculadora.
- `Program.cs`: punto de entrada de consola.
- `Calculadora.Tests/Calculadora.Tests.csproj`: proyecto de pruebas unitarias.
- `Calculadora.Tests/CalculatorTests.cs`: pruebas MSTest.
- `azure-pipelines.yml`: pipeline multistage para Azure DevOps.

## Ejecucion local

```bash
dotnet restore
dotnet build
dotnet test Calculadora.Tests/Calculadora.Tests.csproj
dotnet run
```

## Pipeline DevOps

El pipeline se ejecuta automaticamente cuando hay cambios en la rama `main`.

Flujo configurado: `CI -> Testing -> Delivery`

Stages:

- `CI`: instala .NET SDK, restaura dependencias y compila la aplicacion.
- `Testing`: ejecuta las pruebas unitarias y publica los resultados.
- `Delivery`: publica la aplicacion y genera el artefacto `Calculadora`.

Si una fase falla, Azure DevOps detiene el pipeline y no ejecuta las fases siguientes.

## Evidencia sugerida

- Captura del historial de commits.
- Captura del pipeline ejecutado correctamente.
- Captura de los stages `CI`, `Testing` y `Delivery` en verde.
- Captura del artefacto generado en la etapa `Delivery`.
