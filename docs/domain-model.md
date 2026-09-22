# Domain Model

## User

Represents a person who can use the system and be assigned to tasks.

---

## Project

Represents a collection of work organized into tasks.

---

## Task

Represents a unit of work within a project.

---

# Relationships

User
  └─ Tasks

Project
  └─ Tasks

Task
  ├─ Assigned User
  └─ Project