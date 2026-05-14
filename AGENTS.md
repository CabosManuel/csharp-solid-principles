# AI Agent Guidance for csharp-solid-principles

## Repository overview
- Demonstrates the five SOLID principles with small C#/.NET projects.
- Each numbered folder is a separate principle example:
  - `1-SingleResponsability`
  - `2-OpenClose`
  - `3-LiskovSubstitution`
  - `4-InterfaceSegregation`
  - `5-DependencyInversion`
- `5-DependencyInversion/Api` is an ASP.NET-style dependency inversion example with `Api.Tests` for unit tests.

## Recommended commands
- Build the full solution:
  - `dotnet build csharp-solid-principles.sln`
- Run tests:
  - `dotnet test 5-DependencyInversion/Api.Tests/Api.Tests.csproj`

## Development guidance
- Focus changes on the specific SOLID principle example relevant to the task.
- Preserve the educational/demo style: keep examples small, readable, and idiomatic.
- Avoid modifying generated output in `bin/` and `obj/` directories.
- Use .NET 6 conventions when editing or adding code.

## Notes for agents
- Prefer working inside the principle folder that matches the issue rather than changing unrelated examples.
- The root `README.md` is the main workspace documentation.
- If adding or fixing tests, use the existing xUnit/Moq-based `Api.Tests` project.
