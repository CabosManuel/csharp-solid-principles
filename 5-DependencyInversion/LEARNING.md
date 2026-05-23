# Dependency Inversion Principle

## Objetivo

Entender por qué el código de alto nivel no debería depender directamente de detalles concretos cuando quieres mantenerlo flexible y fácil de probar.

## Qué mirar primero

- `Api/Controllers/StudentController.cs`
- `Api/Repository/StudentRepository.cs`
- `Api/Models/Logbook.cs`
- `Api.Tests/StudentTest.cs`

## Preguntas guía

- ¿Qué dependencias crea directamente `StudentController`?
- ¿Qué problema aparece cuando quieres probar el controlador con datos controlados?
- ¿Por qué el test comentado con `Moq` apunta a una mejor dirección de diseño?
- ¿Qué debería depender de una abstracción y no de una implementación concreta?

## Ejercicio sugerido

1. Identifica los `new` que acoplan el controlador a detalles concretos.
2. Diseña interfaces para las dependencias que el controlador realmente necesita.
3. Pasa esas dependencias por constructor y valida si el test puede usar mocks de forma natural.

## Señales de que vas bien

- el controlador deja de crear por sí mismo repositorio y logbook
- puedes describir qué dependencia se aísla en cada prueba
- el test con mocks deja de sentirse forzado y pasa a ser una consecuencia natural del diseño