# Single Responsibility

## Objetivo

Entender qué significa que una clase tenga una sola razón para cambiar.

## Qué mirar primero

- `StudentRepository.cs`
- `Helper/Exporter.cs`

## Preguntas guía

- ¿Qué responsabilidad tiene `StudentRepository` y cuál no debería tener?
- Si mañana cambia el formato de salida, ¿qué clase debería modificarse?
- Si mañana cambia la fuente de datos, ¿qué clase debería modificarse?
- ¿`Exporter` está exportando o también está tomando decisiones que pertenecen a otra capa?

## Ejercicio sugerido

1. Explica por qué no conviene mezclar repositorio y exportación en la misma clase.
2. Revisa `Exporter` e identifica si tiene una única responsabilidad o si todavía arrastra detalles mezclados.
3. Refactor opcional: elimina duplicación dentro del exportador sin moverle responsabilidades ajenas.

## Señales de que vas bien

- el repositorio no conoce detalles de CSV, encoding o nombre de archivo
- el exportador no se convierte en repositorio ni en validador
- puedes explicar con una frase corta la responsabilidad de cada clase
