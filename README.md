# AJAX CRUD Create - Web API

Welcome to the **AJAX CRUD Create** Web API project! This repository demonstrates a RESTful API implementation using .NET Core Web API, designed to perform Create, Read, Update, and Delete (CRUD) operations with SQL Server and seamless AJAX integration.

---

## Table of Contents

1. [Project Overview](#project-overview)
2. [Features](#features)
3. [Technologies Used](#technologies-used)
4. [Database Setup](#database-setup)
5. [API Endpoints](#api-endpoints)
6. [Getting Started](#getting-started)
7. [License](#license)
8. [Contact](#contact)

---

## Project Overview

This Web API project enables users to perform CRUD operations dynamically through AJAX calls. It is designed for flexibility and scalability, making it suitable for integration with modern front-end applications.

Key highlights:
- Simplified database interactions with SQL Server.
- API endpoints for managing data.
- Built with best practices for RESTful APIs.

---

## Features

- **CRUD Operations**: Perform Create, Read, Update, and Delete operations.
- **AJAX Integration**: Use AJAX to dynamically interact with the API.
- **Database Connectivity**: Direct integration with SQL Server.
- **Scalability**: Designed to be easily extended for additional features.

---

## Technologies Used

- **Framework**: .NET Core Web API
- **Database**: SQL Server
- **Tools**: Visual Studio, Postman

---

## Database Setup

The database schema required for this project is provided in the file:

`SQL_schema.sql`

### Steps to Set Up the Database
1. Locate the `SQL_schema.sql` file in the root of this repository.
2. Open your SQL Server Management Studio (SSMS).
3. Execute the SQL script to create the necessary database schema.
4. Update the connection string in the `appsettings.json` file to match your database configuration.

---

## API Endpoints

The API provides the following endpoints:

1. **GET /api/items**
   - Retrieves all items.
2. **GET /api/items/{id}**
   - Retrieves a single item by ID.
3. **POST /api/items**
   - Creates a new item.
4. **PUT /api/items/{id}**
   - Updates an existing item.
5. **DELETE /api/items/{id}**
   - Deletes an item by ID.

---

## Getting Started

### Prerequisites
- .NET Core SDK
- SQL Server
- Visual Studio or any preferred IDE

### Create .NET CORE WEB API Project

### Some Extension need to be install from Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution..
```bash
   Microsoft.EntityFrameworkCore.SqlServer
   Microsoft.EntityFrameworkCore.Tools
   Swashbuckle.AspNetCore
   Microsoft.Data.SqlClient
   Microsoft.AspNetCore.Mvc.NewtonsoftJson
```
### Installation Steps
1. Clone this repository:
   ```bash
   git clone https://github.com/namrapithwa-tech/AJAX_CRUD_Create_WEBAPI.git
   ```
2. Open the solution in Visual Studio.
3. Update the `appsettings.json` file with your SQL Server connection string.
4. Ensure the database is created by running the SQL script `SQL_schema.sql` in your SQL Server instance.
5. Run the project to start the API server.

---

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

## Contact
For any questions or support, feel free to reach out:

- **Name**: Namra Pithwa
- **GitHub**: [namrapithwa-tech](https://github.com/namrapithwa-tech)
- **Email**: tech.namra@gmail.com
