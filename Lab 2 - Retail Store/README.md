
# 🧾 Lab 2: Setting Up the Database Context for a Retail Store

---

### ✅ **Scenario**

The retail store needs a system to store and manage **product** and **category** data using a **SQL Server** database.
To achieve this, a **database context** (`DbContext`) is created using **Entity Framework Core (EF Core)** to manage database connections and object-relational mapping (ORM).

---

### 🎯 **Objective**

* Understand how to define entity models and set up relationships.
* Configure `DbContext` to map C# classes to SQL Server tables.
* Prepare the application for data storage using EF Core.

---

## 🛠️ **Procedure**

---

### 🔹 Step 1: Create Models

* Identified two core entities: **Product** and **Category**.
* Designed each with relevant properties like ID, name, and price.
* Established a one-to-many relationship:

  * A **Category** can have many **Products**.
  * A **Product** belongs to one **Category**.

---

### 🔹 Step 2: Create the AppDbContext Class

* Defined a class that inherits from EF Core’s `DbContext`.
* Registered both entities (Product and Category) to be tracked and mapped as tables in the database.
* Implemented a configuration method to specify how EF Core should connect to SQL Server using a connection string.

---

### 🔹 Step 3: Add Connection String

* Provided a connection string to connect the application to SQL Server.
* This was done directly in the context configuration for console applications.
* In ASP.NET Core projects, the connection string can optionally be placed in the `appsettings.json` file and accessed through configuration.

---

## ✅ **Outcome**



![retail store](https://github.com/user-attachments/assets/c7b022c4-1b55-43ac-9770-6cd3a4ea59ff)

* Successfully created and structured the core data models of the retail inventory system.
* Established a clear data relationship between products and categories.
* Configured EF Core’s `DbContext` to allow interaction with a SQL Server database.

---
