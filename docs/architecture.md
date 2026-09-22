# Architecture

TaskFlow follows Clean Architecture principles.

## Layers

### Presentation

Responsible for HTTP communication.

Example:
- Controllers
- Endpoints

---

### Application

Contains use cases and application logic.

Example:
- Commands
- Queries
- Handlers

---

### Domain

Contains business rules and entities.

Example:
- User
- Project
- Task

---

### Infrastructure

Contains external implementations.

Example:
- Entity Framework Core
- SQL Server
- Repositories

---

# Dependency Rule

Dependencies always point inward.

Presentation
    ↓
Application
    ↓
Domain

Infrastructure
    ↓
Domain