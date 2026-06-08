---
name: solid-ocp
description: Use when working in 2-OpenClose, discussing Open/Closed Principle, condition-heavy logic, employee types, salary calculation, polymorphism, or strategies.
---

# Open Closed Guidance

- Look for logic that must be edited every time a new case appears.
- In this folder, pay close attention to `Program.cs`, the `List<object>` usage, and type checks that branch on concrete classes.
- Ask questions such as:
  - What code would change if a contractor were added?
  - Can this loop depend on an abstraction instead of concrete types?
  - Are we extending behavior or editing an existing decision tree?
- Prefer polymorphism or well-named strategies over expanding `if` or `else` chains.