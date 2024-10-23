# User Management API

## Overview

This project implements a simple user management system with identity and data protection features. It includes user registration with email and password, using Entity Framework Core and ASP.NET Core.

### Features

- User registration
- Password encryption using BCrypt
- Data validation using Data Annotations
- Entity Framework Core Code First approach

### Installation

1. Clone the repository.
2. Install required packages:
    ```bash
    Install-Package Microsoft.EntityFrameworkCore
    Install-Package Microsoft.EntityFrameworkCore.SqlServer
    Install-Package Microsoft.EntityFrameworkCore.Tools
    Install-Package BCrypt.Net-Next
    ```
3. Update the connection string in `ApplicationDbContext.cs`.
4. Run the following commands to create the database:
    ```bash
    Add-Migration InitialCreate
    Update-Database
    ```

### API Endpoints

#### POST /register

Registers a new user with email and password.

- **Request Body:**
    ```json
    {
      "email": "user@example.com",
      "password": "password123"
    }
    ```
- **Response:**
    ```json
    {
      "message": "User registered successfully"
    }
    ```




