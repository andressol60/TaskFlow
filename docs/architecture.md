# TaskFlow Architecture

## Architecture Style

TaskFlow follows Clean Architecture principles.

---

## Projects

### TaskFlow.Api

Responsible for exposing HTTP endpoints.

### TaskFlow.Application

Responsible for use cases and application logic.

### TaskFlow.Domain

Responsible for business rules and domain entities.

### TaskFlow.Infrastructure

Responsible for external service implementations.

### TaskFlow.Persistence

Responsible for database access using Entity Framework Core.

---

## Dependency Rules

TaskFlow.Api
    ↓
TaskFlow.Application
    ↓
TaskFlow.Domain

TaskFlow.Infrastructure
    ↓
TaskFlow.Domain

TaskFlow.Persistence
    ↓
TaskFlow