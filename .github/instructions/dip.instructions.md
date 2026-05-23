---
description: "Use when working in 5-DependencyInversion, discussing dependency inversion, controllers, repositories, logging, abstractions, dependency injection, ASP.NET, xUnit, or Moq."
name: "Dependency Inversion"
applyTo:
  - "5-DependencyInversion/**/*.cs"
  - "5-DependencyInversion/**/*.md"
---

# Dependency Inversion Guidance

- Look for high-level code that directly creates low-level details.
- In this folder, use `StudentController` as the main example of direct instantiation and tight coupling.
- Connect design choices to testability, especially around `Api.Tests`.
- Ask questions such as:
  - What concrete dependency is the controller tied to?
  - How would you replace that dependency in a test?
  - Which dependency should be expressed as an abstraction?
- Prefer constructor injection and clear interfaces when they improve test seams and reduce coupling.