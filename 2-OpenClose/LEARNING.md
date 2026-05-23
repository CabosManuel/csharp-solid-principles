# Open/Closed Principle

## Objetivo

Entender por qué un diseño debería poder extenderse sin reescribir el mismo bloque de decisión cada vez.

## Qué mirar primero

- `Program.cs`
- `EmployeeFullTime.cs`
- `EmployeePartTime.cs`

## Preguntas guía

- ¿Qué pasa si aparece un nuevo tipo de empleado?
- ¿Qué código tendrías que editar hoy para soportarlo?
- ¿Por qué `List<object>` y las comprobaciones de tipo hacen el flujo más frágil?
- ¿Qué parte debería variar y cuál debería quedarse estable?

## Ejercicio sugerido

1. Identifica exactamente dónde está el punto que viola Open/Closed.
2. Diseña una abstracción para calcular el salario sin preguntar por el tipo concreto en el bucle principal.
3. Imagina un tercer tipo de empleado y comprueba si podrías agregarlo sin tocar la lógica principal.

## Señales de que vas bien

- el flujo principal deja de depender de `if` o `else` por tipo concreto
- desaparece la necesidad de trabajar con `object`
- agregar un nuevo empleado implica extender, no editar el mismo árbol de decisiones
