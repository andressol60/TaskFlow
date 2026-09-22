# Domain Model

## User

###Purpose
Represents a person who can use the system and be assigned to tasks.

###Responsibilities
-Be identified within the system.
-Receive task assignments.
-Participate in projects.

###Conceptual Attributes
-Id
-Name
-LastName
-Email

---

## Project

###Purpose
Represents a collection of work organized into tasks.

###Responsibilities
-List tasks.
-Organize tasks.
-Track projects progress.
-Provide a working context.

###Conceptual Attributes
-Id
-Name
-Description
---

## Task

###Purpose
Represents a unit of work within a project.

###Responsibilities
-Track work status
-Be assigned to a user
-Belong to a project

###Conceptual attributes
-Id
-Title
-Description
-Status
-Assigned user
-Project
---

# Relationships

A User can be assigned many Tasks.

A Project can contain many Tasks.

A Task belongs to one Project.

A Task can be assigned to one User.


# Task Status

-Pending.
-InProgress.
-Done.
---

# Business Rules

BR-01
A task must belong to a project.
BR-02
A task may be assigned to a user.
BR-03
A project may contain multiple tasks.
BR-04
A user may have multiple assigned tasks.
BR-05
A task status must be one of the allowed statuses.