

### **Lab 3: Using EF Core CLI to Create and Apply Migrations**

---

#### **Scenario:**

You are developing a database for a retail store application. The models like `Product` and `Category` have already been defined in the application. Now, you need to create a database using **Entity Framework Core CLI (Command Line Interface)** by applying migrations.

---

#### **Objective:**

To learn how to use **EF Core CLI** to:

* Generate database schema from models.
* Apply those changes to a SQL Server database.

---

#### **Procedure:**

1. ### Install EF Core CLI (If Not Already Installed)

   * Use the command-line interface to install the **dotnet-ef** tool globally.
   * This tool allows you to work with migrations and update the database schema.

2. ###  Generate an Initial Migration

   * Use the EF CLI to create the first migration.
   * This step will create a new **Migrations folder** in your project.
   * The folder contains auto-generated C# files that represent the current model structure.

3. ### Apply the Migration to the Database

   * Use EF CLI to apply the migration and **create the actual database and tables** in your configured SQL Server.
   * This step ensures the database reflects the models defined in your application.

4. ###  Verify the Database in SQL Server

   * Open **SQL Server Management Studio (SSMS)** or **Azure Data Studio**.
   * Connect to the same server specified in your application’s connection string.
   * Expand the database and confirm that **Products** and **Categories** tables are created under the appropriate database.

---

#### **Outcome:**

![lab 3](https://github.com/user-attachments/assets/9d5eb6c0-0f6f-4224-85c1-965346e4a8af)



* Successfully installed EF Core CLI.
* Created initial migration scripts.
* Applied those migrations to generate a SQL Server database.
* Verified the creation of tables in SQL Server.

---

Let me know if you want this in a GitHub README format or PDF format next!
