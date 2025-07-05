
# 🧾 Lab 4: Inserting Initial Data into the Database

---

### ✅ **Scenario**

The **store manager** wants to populate the system with **initial data** such as product categories and items.
To achieve this, records need to be inserted into the database using **Entity Framework Core (EF Core)**.

---

### 🎯 **Objective**

* Learn how to **add new records** to the database using EF Core methods.
* Understand how to use **asynchronous operations** like `AddAsync` and `SaveChangesAsync` to maintain performance and responsiveness.
* Confirm that data is persisted by checking the SQL Server database.

---

## 🛠️ **Procedure**

---

### 🔹 Step 1: Insert Initial Data

* Opened the main application entry point.
* Created a database context instance using `AppDbContext`.
* Defined two **categories** (e.g., Electronics and Groceries).
* Created two **products**, each linked to one of the categories.
* Used EF Core’s async methods to:

  * Add the category and product data.
  * Save all changes to the database.

---

### 🔹 Step 2: Run the Application

* Executed the application using the command-line interface.
* EF Core automatically connected to the configured SQL Server and inserted the data into the relevant tables.

---

### 🔹 Step 3: Verify in SQL Server

* Opened **SQL Server Management Studio (SSMS)** or **Azure Data Studio**.
* Navigated to the appropriate database.
* Queried the **Categories** and **Products** tables.
* Verified that the inserted records (like “Laptop” and “Rice Bag”) appeared correctly with associated category data.

---

## ✅ **Outcome**
![Inserting Initial Data](https://github.com/user-attachments/assets/22ab8c4a-33ce-4e72-9c07-e3c4255c8053)


* Successfully inserted initial seed data into the database using EF Core.
* The use of async methods ensured efficient and non-blocking database operations.
* Verified persistence by checking SQL Server — confirming that the data was stored correctly.


