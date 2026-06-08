---
name: solid-lsp
description: Use when working in 3-LiskovSubstitution, discussing inheritance, base contracts, substitutability, behavior preservation, or derived types that break expectations.
---

# Liskov Substitution Guidance

- Focus on whether a derived type can be used anywhere the base type is expected.
- Pay attention to changes in behavior, hidden preconditions, or special cases that surprise the caller.
- Ask questions such as:
  - What promises does the base type make?
  - Would the caller need extra `if` checks for one derived type?
  - Does inheritance help here, or is it forcing an unnatural relationship?
- Prefer designs where the caller does not need to know the concrete subtype to behave safely.