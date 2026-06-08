# Proyecto de estudio: Principios SOLID en C#

Este repositorio está pensado para estudiar C#, .NET, refactor, testing y los principios SOLID con ejemplos pequeños. La meta no es solo que el código funcione: la meta es entender por qué un diseño es mejor o peor y practicar cómo mejorarlo paso a paso.

La solución actual usa .NET 10 (`net10.0`).

Si estás siguiendo el curso original, puedes partir de la rama `master` o de la rama `0-codigobase`, según el punto desde el que quieras comenzar.

## Qué vas a practicar

- sintaxis base de C# y lectura de código ajeno
- programación orientada a objetos
- detección de acoplamiento y baja cohesión
- refactor guiado por principios SOLID
- fundamentos de ASP.NET, inyección de dependencias y testing

## Estructura del repositorio

- `1-SingleResponsability`: una primera mirada a responsabilidad única y separación de responsabilidades
- `2-OpenClose`: cómo detectar lógica que obliga a modificar el mismo bloque cada vez que aparece un caso nuevo
- `3-LiskovSubstitution`: cómo razonar sobre contratos, herencia y sustitución segura
- `4-InterfaceSegregation`: cómo identificar interfaces demasiado grandes o mal repartidas entre roles
- `5-DependencyInversion`: cómo reducir acoplamiento y mejorar testabilidad en una API pequeña

Cada carpeta contiene su propio ejemplo y ahora también puede contener una guía `LEARNING.md` para estudiar el principio de forma activa.

## Ruta sugerida de estudio

1. Empieza por `1-SingleResponsability` y entiende qué significa "una razón para cambiar".
2. Sigue con `2-OpenClose` para ver por qué algunos diseños crecen a punta de `if` y `else`.
3. Después revisa `3-LiskovSubstitution` para detectar cuándo una herencia obliga al cliente a saber demasiado.
4. Continúa con `4-InterfaceSegregation` para separar capacidades por rol.
5. Termina con `5-DependencyInversion`, donde ya aparecen ASP.NET, controller, dependencias y pruebas.

## Cómo usar Copilot / OpenCode en este repo

La configuración del proyecto está pensada para que actúe más como tutor que como generador automático de respuestas.

Si quieres reforzar todavía más ese comportamiento:

- **Copilot**: selecciona el agente personalizado `Study Teacher` desde el selector de agentes de Copilot Chat.
- **OpenCode**: usa el agente `Study Teacher` o activa el skill `study-mode` para un comportamiento guiado.

Úsalo así:

- pídele diagnóstico antes que solución: `Ayúdame a detectar qué principio SOLID se está rompiendo aquí.`
- pídele preguntas guía: `Hazme 3 preguntas para comprobar si entendí este archivo.`
- pídele pistas graduales: `No me des la solución todavía; dame la siguiente pista.`
- pídele revisión conceptual: `Revisa mi refactor y dime qué estoy razonando mal.`
- cuando de verdad quieras el código, dilo de forma explícita: `Ahora sí, muéstrame una posible implementación.`


## Flujo recomendado por carpeta

1. Lee el código sin tocar nada y anota qué te incomoda o qué no entiendes.
2. Abre el `LEARNING.md` de esa carpeta y responde las preguntas antes de cambiar código.
3. Pide al asistente una pista o un diagnóstico, no la solución completa.
4. Haz un refactor pequeño.
5. Vuelve a pedir revisión: qué mejoró, qué sigue mal y qué opción sería más mantenible.
6. Ejecuta el proyecto o las pruebas disponibles para validar.

## Comandos útiles

- comprobar tu SDK instalado:

```bash
dotnet --version
```

- construir toda la solución:

```bash
dotnet build csharp-solid-principles.slnx
```

- ejecutar un ejemplo de consola desde su carpeta:

```bash
dotnet run
```

- ejecutar las pruebas disponibles hoy:

```bash
dotnet test 5-DependencyInversion/Api.Tests/Api.Tests.csproj
```

## Nota importante

- evita editar `bin/` y `obj/`, porque son carpetas generadas
- intenta mantener los cambios pequeños y comparables, ya que este repo se usa para aprender
- si algo funciona pero no entiendes por qué, detente y pide explicación antes de seguir agregando código
