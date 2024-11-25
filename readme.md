# Data Access in ASP.NET

This repository is dedicated to exploring various data access techniques in ASP.NET applications. It serves as a learning resource to understand different approaches for interacting with databases in .NET development.

## Key Topics Covered

### 1. **ADO.NET**
   - Working with raw database connections, commands, and readers.
   - Managing connections and transactions manually for fine-grained control.

### 2. **Dapper**
   - Lightweight ORM for executing raw SQL queries.
   - Mapping results directly to objects for streamlined data access.

### 3. **Entity Framework Core**
   - Full-fledged ORM for building data access layers.
   - Two main approaches:
     - **Code-First with Migrations:** Define your database schema using C# classes and evolve it with migrations.
     - **Database-First with Reverse Engineering:** Scaffold the database schema into C# classes using EF Core tools.

## Purpose

The primary purpose of this repository is educational. It demonstrates:
- Different ways to interact with databases in ASP.NET.
- How to use ADO.NET, Dapper, and Entity Framework Core effectively.
- Practical examples of both **Code-First** and **Database-First** workflows.

## Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/<your-username>/<repo-name>.git
