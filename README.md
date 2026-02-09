Udemy The 4 th Project
# 🛒 ASP.NET Core MVC E-Commerce Project

A full-featured **ASP.NET Core MVC** application built using a **3-Layer Architecture + Common Layer**, following clean architecture principles and best practices.  
The project focuses on **maintainability, scalability, and real-world features** commonly used in production systems.

---

## 🧱 Architecture Overview

The solution is structured into **4 main layers**:

### 🔹 Common Layer
Shared components used across the entire application:
- Domain Entities
- Result Pattern (Success / Failure handling)
- Common models and base classes

---

### 🔹 Data Access Layer
Responsible for all database-related operations:
- Entity Framework Core DbContext
- Identity configuration
- Fluent API configurations
- Repository implementations
- Identity services implementations

---

### 🔹 Services Layer
Contains business logic and application services:
- DTOs
- Interfaces for repositories and services
- Business service implementations
- Email service implementation
- Services unrelated to Identity

---

### 🔹 Web Layer (MVC)
The presentation layer:
- MVC Controllers
- ViewModels
- Razor Views
- `CurrentUserService` implementation
- TempData handling for UI alerts

---

## 🛠️ Technical Features

- ✅ ASP.NET Core MVC
- ✅ AutoMapper
- ✅ Dependency Injection per layer
- ✅ Repository Pattern
- ✅ Unit of Work Pattern
- ✅ Result Pattern for clean error handling

---

## 🔐 Authentication & Authorization

- ASP.NET Core Identity
- User Registration & Login
- Email Verification (verify now or later)
- Forgot / Reset / Change Password
- Role-based Authorization
  - **Admin**
  - **Customer**

---

## 🛍️ E-Commerce Features

- Product listing with:
  - Pagination
  - Single-column Sorting
  - Search (by Name or Brand)
- Shopping Cart:
  - Cookie-based storage
  - JSON serialization → encoding → storage
  - `TempData.Keep()` support for multi-step usage
- Upload & Delete product images
- PayPal payment integration

---

## 📧 Email Service

- Email sending via **Brevo**
- Used for:
  - Account confirmation
  - Password reset
  - Notifications

---

## 💳 Payments

- PayPal payment gateway integration
- Secure checkout flow

---

## 🎯 Additional Features

- TempData alerts for UI feedback
- Clean separation of concerns
- Scalable and extensible architecture
- Beginner-to-intermediate friendly structure

---

## 🚀 Purpose of the Project

This project was built as a **learning and practice application** to apply:
- Clean architecture concepts
- Design patterns
- ASP.NET Core Identity
- Real-world MVC project structure

---

## 📌 Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- AutoMapper
- PayPal SDK
- Brevo Email API

---

## 👨‍💻 Author

**Youssef Mohamad Abdelfattah**  
Full Stack Web Developer  

---

⭐ If you like the project, feel free to star the repository!
