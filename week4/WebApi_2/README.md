
# SwaggerEmployeeApi - ASP.NET Core Web API with Swagger & Postman Demo

This project demonstrates how to create a **Web API** in ASP.NET Core using **Swagger for documentation** and **Postman** for testing. It showcases complete CRUD operations for managing `Employee` records and includes proper routing, response types, and metadata via Swagger annotations.

---

## 🎯 Objectives

- Enable Swagger in ASP.NET Core Web API
- Use `[ProducesResponseType]` for documenting responses
- Create and test API routes for employee management
- Demonstrate Postman usage for different HTTP verbs
- Customize routing with `[Route]`, named actions, and route parameters

---

## 🛠️ Setup Instructions

1. **Clone or open the project in Visual Studio**
2. **Restore NuGet packages**, especially:
```

Swashbuckle.AspNetCore

```
3. **Run the project**

By default, it will launch Swagger at:


[https://localhost:7087/swagger](https://localhost:7087/swagger)

````

---

## 📁 Project Structure

| File                    |     Description                         |
|-------------------------|-----------------------------------------|
| `Program.cs`            |  Middleware pipeline and Swagger config |
| `EmployeeController.cs` | Contains all API endpoints (`/api/emp`) |
| `Employee.cs`           |Employee model with Id, Name, Department |

---

## 🧪 API Endpoints

| Method | Endpoint             | Description         |
|--------|----------------------|---------------------|
| GET    | `/api/emp`           | Get all employees   |
| GET    | `/api/emp/{id}`      | Get employee by ID  |
| POST   | `/api/emp`           | Add a new employee  |
| PUT    | `/api/emp/{id}`      | Update employee     |
| DELETE | `/api/emp/{id}`      | Delete employee     |

---

## 🔍 Swagger Preview
````
![alt text](Outputs\swagger-ui.png)

- Contact details and license info from `Program.cs` appear in the header
- All Employee API routes are listed and interactive

---

## 🧾 Sample Outputs (Postman)

### ➕ POST - Add New Employee

**Request Body:**
```json
{
  "name": "David",
  "department": "Finance"
}
````

**Response:**

```json
{
  "id": 3,
  "name": "David",
  "department": "Finance"
}
```

![alt text](Outputs\POST.png)

---

### 🖊️ PUT - Update Employee

```json
{
  "name": "Alice Updated",
  "department": "HR"
}
```

![alt text](E-commerce.png)

---

### ✅ GET - All Employees

![alt text](Outputs\GET.png)

---

### 🔍 GET - Employee Not Found

* Try `/api/emp/1` after deletion

![alt text](Outputs\GET1.png)

---

### ❌ DELETE - Remove Employee

![alt text](Outputs\DELETE.png)

---

### 📘 Swagger Endpoint Result

Using the Swagger UI to execute a `GET`:

![alt text](Outputs\GET-ui.png)

---

## 🧩 Tech Stack

* ASP.NET Core 6 Web API
* C#
* Swagger (Swashbuckle.AspNetCore)
* Postman (for manual API testing)

---

