# Interface Segregation Principle

## Objetivo

Entender por qué una interfaz demasiado amplia obliga a clases concretas a fingir comportamientos que no les corresponden.

## Qué mirar primero

- `IActivities.cs`
- `Developer.cs`
- `Tester.cs`
- `ScrumMaster.cs`

## Preguntas guía

- ¿Todos los roles necesitan realmente todos los métodos de `IActivities`?
- ¿Qué te dice una implementación que lanza excepciones en varios métodos?
- ¿Qué comportamientos pertenecen a un desarrollador, cuáles a un tester y cuáles a un scrum master?
- ¿Qué interfaces pequeñas representarían mejor esos roles?

## Ejercicio sugerido

1. Haz una lista de capacidades por rol.
2. Divide `IActivities` en interfaces pequeñas y con intención clara.
3. Revisa si cada clase concreta implementa solo lo que necesita y deja de lanzar excepciones por métodos ajenos.

## Señales de que vas bien

- desaparecen implementaciones falsas o excepciones por métodos no usados
- cada interfaz tiene un propósito fácil de describir
- las clases concretas quedan más pequeñas y más honestas respecto a su rol
