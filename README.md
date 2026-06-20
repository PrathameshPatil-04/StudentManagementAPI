# Student Management API

## Overview

Student Management API is a RESTful Web API developed using **ASP.NET Core (.NET 10)** and **Entity Framework Core**. It provides secure authentication using **JWT (JSON Web Token)** and allows authenticated users to perform CRUD operations on student records.

---

## Features

* User Authentication using JWT
* Login API
* Student CRUD Operations

  * Get All Students
  * Get Student By ID
  * Add Student
  * Update Student
  * Delete Student
* Protected Endpoints using JWT Authentication
* Entity Framework Core with SQL Server
* Database Migrations
* Seeded Dummy User Data
* Swagger API Documentation

---

## Technologies Used

* ASP.NET Core 10 Web API
* C#
* Entity Framework Core
* SQL Server
* JWT Authentication
* Swagger (Swashbuckle)
* Visual Studio 2022

---

## Project Structure

```
StudentManagement
│
├── Controllers
│   ├── AuthController.cs
│   └── StudentsController.cs
│
├── Data
│   └── AppDbContext.cs
│
├── DTOs
│
├── Models
│
├── Migrations
│
├── Program.cs
├── appsettings.json
└── StudentManagement.csproj
```

---

## Database Setup

1. Update the SQL Server connection string in `appsettings.json`.

2. Open Package Manager Console and run:

```
Add-Migration InitialCreate
Update-Database
```

The database and tables will be created automatically.

---

## Authentication

### Login Endpoint

```
POST /api/Auth/login
```

Sample Request

```json
{
  "username": "admin",
  "password": "admin123"
}
```

Sample Response

```json
{
  "token": "<JWT_TOKEN>"
}
```

Use the returned JWT token in the Authorization header:

```
Authorization: Bearer <JWT_TOKEN>
```

---

## Student APIs

### Get All Students

```
GET /api/Students
```

### Get Student By Id

```
GET /api/Students/{id}
```

### Add Student

```
POST /api/Students
```

```json
{
  "name": "John Doe",
  "email": "john@example.com",
  "phone": "9876543210"
}
```

### Update Student

```
PUT /api/Students/{id}
```

```json
{
  "name": "Updated Name",
  "email": "updated@example.com",
  "phone": "9999999999"
}
```

### Delete Student

```
DELETE /api/Students/{id}
```

---

## Security

All Student CRUD endpoints are protected using JWT Authentication.

Users must authenticate through the Login API before accessing protected endpoints.

---

## Author

**Prathamesh Patil**

ASP.NET Core Full Stack Developer

GitHub:
https://github.com/PrathameshPatil-04
