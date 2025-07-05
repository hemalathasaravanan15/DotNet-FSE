

# 🧾 Implementing a Retail Inventory System Using EF Core

---

### ✅ Scenario:

You are developing a **retail inventory management system** that keeps track of **products**, **categories**, and **stock levels** in a **SQL Server database**.
To ensure **maintainability, scalability**, and reduce manual SQL operations, you adopt **Entity Framework Core (EF Core)** — a powerful Object-Relational Mapper (ORM) in .NET.

---

### 🧠 Objective:

* Understand the concept of ORM (Object-Relational Mapping).
* Use EF Core 8.0 to map C# classes to relational tables.
* Design and implement a basic inventory system with models and relationships.
* Learn how to apply migrations and persist data using EF Core tools.

---

## 🛠️ Steps Followed:

---

### 🔹 Step 1: Project Setup

* Created a new .NET Console Application named `RetailInventory`.
* Organized the project into folders:

  * A **Models** folder to store entity classes (e.g., `Product`, `Category`).
  * A **Data** folder for the EF Core context class (`AppDbContext`).
* Ensured that all files were structured and named clearly for ease of navigation and maintenance.

---

### 🔹 Step 2: Defining Data Models

* Identified the main entities: **Product** and **Category**.
* Established relationships:

  * A **product** belongs to one **category**.
  * A **category** can have multiple **products**.
* Designed these entities to reflect real-world retail data structures.

---

### 🔹 Step 3: Creating the DbContext

* Created a class to serve as the **bridge between C# classes and the database**.
* Registered each entity as a table using EF Core's context setup.
* Configured the context to connect to a **SQL Server database** using a connection string.

---

### 🔹 Step 4: Installing EF Core Dependencies

* Installed necessary EF Core NuGet packages to support SQL Server and migration features.
* Ensured tools were in place to use **EF CLI** for database operations like migrations and updates.

---

### 🔹 Step 5: Applying Migrations

* Used EF Core CLI to generate the initial migration.
* Applied the migration to create a database schema in SQL Server based on the defined models.
* Verified that the **Products** and **Categories** tables were successfully created.

---

### 🔹 Step 6: Testing Data Access

* Initialized the database with sample data (categories and products).
* Retrieved data using asynchronous methods like `ToListAsync`, `FindAsync`, and `FirstOrDefaultAsync`.
* Printed the results to verify that data retrieval and relationships were working as expected.

---

## 🧾 Outcome:

![retailinventory](https://github.com/user-attachments/assets/5dea260a-ddd2-4030-808f-a9de4efa7edc)


* The application successfully connected to SQL Server and performed database operations.
* Tables and relationships were correctly created using EF Core migrations.
* Data was inserted and retrieved with minimal SQL, showcasing the power of **ORM**.
* This lab demonstrated how EF Core improves **productivity**, **maintainability**, and **data access abstraction** in .NET applications.


