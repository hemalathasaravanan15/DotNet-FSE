
#  Lab 5: Retrieving Data from the Database

---

###  **Scenario**

The **retail store dashboard** needs to display a list of products along with their details such as name and price.
To support this, the application must retrieve data from the SQL Server database using **Entity Framework Core (EF Core)**.

---

###  **Objective**

* Use EF Core’s **asynchronous query methods** to fetch data from the database.
* Retrieve:

  * A complete list of products.
  * A product by its unique identifier (ID).
  * A product based on a specific condition (e.g., expensive products).
* Display the retrieved information for use in the application dashboard.

---

##  **Procedure**

---

### Step 1: Retrieve All Products

* Established a connection to the database using the configured context.
* Retrieved the full list of product records from the database table.
* Iterated through each product and displayed its details, including name and price.

---

###  Step 2: Retrieve Product by ID

* Queried the database to find a single product using its **primary key (ID)**.
* This method is efficient and optimized for primary key lookups.
* Displayed the product details if the product was found.

---

###  Step 3: Retrieve Product Based on Condition

* Queried the database to find the **first product** that matches a specific condition.
* In this case, the condition was checking for a product with a **price greater than ₹50,000**.
* If such a product existed, its name was displayed to indicate it as an “expensive” item.

---

## **Outcome**

![retrieve](https://github.com/user-attachments/assets/82bbad68-44c1-4570-b88f-d8bbc7535be1)



* Successfully retrieved different sets of data from the SQL Server database using EF Core.
* Demonstrated three common ways of querying data:

  * Getting **all records**.
  * Looking up by **ID**.
  * Filtering using **conditions**.
* Confirmed that asynchronous methods help keep the application responsive and efficient.

