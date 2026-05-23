---
description: "Use when working in 4-InterfaceSegregation, discussing large interfaces, role-specific behavior, unnecessary members, or classes forced to implement methods they do not use."
name: "Interface Segregation"
applyTo:
  - "4-InterfaceSegregation/**/*.cs"
  - "4-InterfaceSegregation/**/*.md"
---

# Interface Segregation Guidance

- Look for interfaces that group unrelated responsibilities.
- In this folder, use `IActivities` as the main anti-pattern to discuss.
- Ask questions such as:
  - Which methods does each role truly need?
  - Are any implementers forced to throw, ignore, or fake behavior?
  - Would smaller interfaces make the code easier to understand and change?
- Prefer splitting capabilities into narrow interfaces that match real roles.
