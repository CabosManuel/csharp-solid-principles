---
description: "Use when working in 1-SingleResponsability, discussing single responsibility, cohesion, repositories, exporters, validators, or classes that do too many things."
name: "Single Responsibility"
applyTo:
  - "1-SingleResponsability/**/*.cs"
  - "1-SingleResponsability/**/*.md"
---

# Single Responsibility Guidance

- Focus on one reason to change per class.
- Watch for code that mixes storage, formatting, export, validation, or orchestration.
- Use the contrast between `StudentRepository` and `Helper/Exporter` to explain separation of concerns.
- Ask questions such as:
  - What responsibility belongs in this class?
  - What would change if the export format changed tomorrow?
  - Is this class deciding, storing, and formatting at the same time?
- Prefer refactors that split behavior into small, named classes instead of hiding complexity inside one class.
