# Liskov Substitution Principle

## Objetivo

Entender cuándo una herencia realmente permite sustitución segura y cuándo obliga al cliente a saber demasiado.

## Qué mirar primero

- `Employee.cs`
- `EmployeeFullTime.cs`
- `EmployeeContractor.cs`

## Preguntas guía

- ¿Qué promete el tipo base `Employee`?
- ¿Por qué `CalculateSalary(bool isFullTime)` obliga al cliente a conocer un detalle que debería estar encapsulado?
- Si el cliente tiene que pasar una bandera para que el comportamiento sea correcto, ¿sigue habiendo una sustitución limpia?
- ¿La herencia está simplificando o escondiendo una decisión débil?

## Ejercicio sugerido

1. Explica por qué una bandera booleana dentro del contrato puede ser una señal de diseño débil.
2. Propón una forma en que cada subtipo se haga cargo de su propio cálculo sin pedir al cliente que sepa de qué tipo es.
3. Comprueba si el código cliente puede trabajar con `Employee` sin hacer preguntas extras.

## Señales de que vas bien

- el código cliente no necesita una bandera o conocimiento externo para usar el contrato
- cada subtipo respeta la expectativa del tipo base
- puedes cambiar un subtipo por otro sin romper el flujo del consumidor
