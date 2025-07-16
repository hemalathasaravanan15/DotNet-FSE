
##  Web API with Custom Models, Filters, and Exception Handling

###  Scenario

This project simulates a basic **Employee Management System API** developed using **ASP.NET Core (.NET 9.0)**. The goal was to create a Web API capable of handling structured employee data with nested models, enforce custom authorization logic using filters, and gracefully handle exceptions.

The API exposes endpoints to retrieve and submit employee data, validates Authorization tokens via custom filters, and logs exceptions using a global exception filter.

This task was completed as part of academic learning to understand:

* RESTful API behavior
* Model binding
* Action filters and exception filters
* Testing APIs using Swagger and Postman

---

###  Step-by-Step Procedure

####  1. Setup and Model Definition

* A new Web API project was created using `.NET 9.0`.
* Created model classes:

  * `Employee` with properties: Id, Name, Salary, Permanent, Department (object), Skills (list), DateOfBirth.
  * Nested models: `Department` and `Skill`.
* This model represents a real-world employee profile with structured data.

####  2. Controller and Action Methods

* Created `EmployeeController` with HTTP methods:

  * **GET**: Returns a static list of employees using a helper method `GetStandardEmployeeList()`.
  * **POST & PUT**: Accepts employee objects using `[FromBody]` from the request body.
* Used `ProducesResponseType` to document expected status codes (200 and 500).
* Included `[AllowAnonymous]` to allow access without authentication for testing.
* Forced an exception in GET to test exception filter response.

####  3. Custom Authorization Filter

* Created a `Filters` folder and added `CustomAuthFilter` inheriting `ActionFilterAttribute`.
* Logic implemented:

  * If `Authorization` header is missing ➝ return 400 with "Invalid request - No Auth token".
  * If header is present but doesn’t contain `"Bearer"` ➝ return 400 with "Token present but Bearer unavailable".
* Applied `[ServiceFilter(typeof(CustomAuthFilter))]` to `EmployeeController`.
* Registered the filter as a service in `Program.cs`.
* Verified this using **Postman** by varying request headers.

####  4. Custom Exception Filter

* Created `CustomExceptionFilter` implementing `IExceptionFilter`.
* On encountering an exception:

  * Captures exception details from `context.Exception`.
  * Logs the message to a local file.
  * Sets the result to a `500 Internal Server Error` using `ObjectResult`.
* Registered globally to apply across all controllers.
* Tested by throwing an exception in the GET method and checking error logging.

####  5. Testing Tools

* **Swagger UI** was used to test:

  * GET, POST, and PUT methods.
  * Status codes (200 and 500) with proper descriptions.
* **Postman** was used to:

  * Send requests with and without Authorization headers.
  * Observe the behavior of custom filters and request validation.

---

###  Outcome

![IMG-20250716-WA0005](https://github.com/user-attachments/assets/2b808a4a-01b3-41f7-b80c-26a3bf06c39c)


![IMG-20250716-WA0006](https://github.com/user-attachments/assets/695f236e-8df3-408d-b703-59b1b1b07b21)


![IMG-20250716-WA0007](https://github.com/user-attachments/assets/f2c04b02-ad3b-4d05-a3ab-4fdab9b12e02)


![IMG-20250716-WA0008](https://github.com/user-attachments/assets/7bea1c88-8926-4f2f-a23d-41673af1219d)


![IMG-20250716-WA0009](https://github.com/user-attachments/assets/f6bdeca5-4140-48f6-82bd-fe399a564d36)


![IMG-20250716-WA0010](https://github.com/user-attachments/assets/5e83a6ed-7283-449f-9b19-d24b7107337e)


![IMG-20250716-WA0011](https://github.com/user-attachments/assets/00f82dd4-9452-4353-8f2e-8a9faaef594e)


By completing this project, the following objectives were successfully achieved:

*  Built a **fully working Web API** with custom model binding using nested objects and lists.
*  Demonstrated how to receive request bodies using `[FromBody]`.
*  Applied a **custom Authorization filter** to intercept headers and validate tokens.
*  Created a **custom exception filter** to capture unhandled errors and log them to a file.
*  Used **Swagger** and **Postman** to test and validate the API's behavior under different conditions.
*  Installed and configured `Microsoft.AspNetCore.Mvc.WebApiCompatShim` to support compatibility features for exception handling.

This project provided a strong foundation in building secure and well-structured APIs using ASP.NET Core.


