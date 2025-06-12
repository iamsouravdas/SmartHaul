## Clean Architecture Layers

1.  Domain Layer (Core business logic)

    1.1. Entities (e.g., Dock, Truck, DockAllocation)
    1.2. Interfaces (e.g., IDockAllocatorService, IDockRepository)
    1.3. Value Objects and domain services

2.  Application Layer

    2.1. Use Cases / Services (e.g., AllocateDockUseCase)
    2.2. DTOs, interfaces
    2.3. Interfaces for repositories and external systems

3.  Infrastructure Layer

    3.1. EF Core DbContext
    3.2. Repositories implementing interfaces
    3.3. Configuration (like EntityTypeConfigurations)
    3.4. Database Migrations

4.  API Layer (Presentation)

    4.1. Controllers
    4.2. Request/Response Models
    4.3. Dependency Injection configuration
    4.4. Middleware

---

## Technologies

1 .NET 7/8
2 EF Core
3 SQL Server / PostgreSQL
4 Swashbuckle (Swagger UI)
5 MediatR (for use case orchestration, optional)
6 AutoMapper (for DTO <-> Entity mapping)

## Architecture

Access to Infrastructure for DI setup

Advantages of This Architecture
Feature Benefit

1. Separation of Concerns Keeps business logic isolated from UI and data layers
2. Testability Easy to write unit tests for core logic by mocking dependencies
3. Plugability You can swap Infrastructure (e.g., change database) without affecting business logic
4. Better Maintainability Easier to scale, debug, and add new features without breaking the rest

5. Real-World Analogy
   Imagine a car:

Domain = engine design blueprints (rules, contracts)

Application = driving system (how acceleration, braking works)

Infrastructure = actual car parts (engine, tires, wiring)

API = steering wheel, dashboard (UI to interact)

Domain <-- No dependency
↑
Application <-- Depends only on Domain
↑
Infrastructure <-- Depends on Application + Domain
↑
API <-- Depends on Application + Infrastructure

1.  DockAllocator.Application → DockAllocator.Domain

-> The Application layer contains business use cases (like AllocateDock).
-> It uses entities and interfaces from the Domain layer.
Example: IDockRepository, Truck, Dock.

2. DockAllocator.Infrastructure → Application + Domain

-> The Infrastructure layer contains the concrete implementations like:

Entity Framework repositories
-> SQL Server DB context

External services
-> It implements interfaces defined in Domain/Application layers.

3. DockAllocator.API → Application + Infrastructure
   The API layer is your entry point (controllers, routes).

It needs:

Access to Application services/use cases

---

## Adding References

dotnet add DockAllocator.Application reference DockAllocator.Domain
dotnet add DockAllocator.Infrastructure reference DockAllocator.Application
dotnet add DockAllocator.Infrastructure reference DockAllocator.Domain
dotnet add DockAllocator.API reference DockAllocator.Application
dotnet add DockAllocator.API reference DockAllocator.Infrastructure

cd ../DockAllocator.API
dotnet add package Swashbuckle.AspNetCore

---

## Steps:

1. mkdir dock-allocator-api
2. cd dock-allocator-api
3. create a solution. dotnet new sln -n dock-allocator-api
4. dotnet new classlib -n DockAllocator.Domain
5. dotnet new classlib -n DockAllocator.Application
6. dotnet new classlib -n DockAllocator.Infrastructure
7. dotnet new webapi -n DockAllocator.API
8. Add Project to the solution: dotnet sln add DockAllocator.Domain
   dotnet sln add DockAllocator.Application
   dotnet sln add DockAllocator.Infrastructure
   dotnet sln add DockAllocator.API
   9: Set Project References

9. Created the models for Truck , Dock, Dock Allocation, User, Warehouse in the domain layer.

10. Let me know when this is done.
Then we’ll:

✅ Create the AppDbContext

✅ Configure the relationships with Fluent API

✅ Add your PostgreSQL connection string

✅ Add and run the first migration
---
