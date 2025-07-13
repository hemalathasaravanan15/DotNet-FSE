

## Scenario

A company needs to develop a simple Web API to manage employee records. The requirements include creating an API to perform basic read and write actions, document it using Swagger, and test it using Postman. Additionally, the API should demonstrate:

* Use of route customization for cleaner URLs
* Returning custom model data
* Securing endpoints using custom authorization filters
* Handling exceptions gracefully
* Displaying clear API documentation through Swagger

The implementation must be carried out using .NET Core Web API and tested locally.

---

## Procedure

### 1. Create a .NET Core Web API Project

* Set up a new Web API project using the standard template.
* Open the project in Visual Studio Code.
* Confirm that default configurations and launch settings are present.

### 2. Add Swagger Documentation Support

* Install the Swashbuckle.AspNetCore NuGet package.
* Register Swagger services and configure the Swagger UI endpoint.
* Run the application and verify the Swagger UI loads in the browser.
* Check if metadata like title, version, and contact information is displayed.

### 3. Create a Custom Model and Controller

* Define a model class representing an Employee, including properties like ID, name, salary, department, and skills.
* Create a controller called `EmployeeController` with:

  * A GET method to return a list of employees.
  * A POST method to add a new employee using `[FromBody]`.

### 4. Customize Route

* Use the `Route` attribute to rename the route to something user-friendly, such as `api/emp`.
* Ensure that API methods are accessible using the new route in Swagger and Postman.

### 5. Add Custom Authorization Filter

* Create a custom filter that checks for the presence of the `Authorization` header.
* Validate that the value contains the keyword `Bearer`.
* If the header is missing or invalid, return a `BadRequest` response with a clear message.
* Apply this filter to the controller so that all requests go through this validation.

### 6. Add Custom Exception Filter

* Create a filter to catch exceptions and log them into a file.
* Override the exception handling method and capture details such as the exception message and stack trace.
* Apply this filter globally or at the controller level.
* Trigger an intentional exception in the GET method to verify this behavior.

### 7. Test API Using Swagger

* Access `https://localhost:[port]/swagger`.
* Test the GET method using the "Try it out" button and verify the list of employees is returned.
* Use the POST method to submit a new employee record and verify the result.

### 8. Test API Using Postman

* Create a collection in Postman named "EmployeeAPI".
* Add two requests:

  * GET request to `/api/emp` with Authorization header
  * POST request with JSON body and Authorization header
* In the POST request, provide sample JSON matching the employee model.
* Check the response body and status code to confirm successful execution.

### 9. Upload Project to GitHub

* Create a new GitHub repository.
* Initialize git in the local project folder.
* Commit all project files and push to the remote repository.
* Include this documentation in the README file for clarity.

---

## Outcome:



<img width="1365" height="719" alt="Screenshot 2025-07-13 205508" src="https://github.com/user-attachments/assets/8d8a4b39-9489-43d5-9f89-fc4f0d5c7201" />




<img width="1365" height="718" alt="Screenshot 2025-07-13 211828" src="https://github.com/user-attachments/assets/89187c09-4e25-4f65-8d41-18aefad4cb5a" />



* A functional .NET Core Web API was developed with Swagger integration.
* API endpoints were documented and tested using Swagger UI and Postman.
* Custom route names made URLs cleaner and more intuitive.
* The `[FromBody]` attribute successfully enabled receiving structured JSON input.
* Custom action filters enforced the presence of an Authorization token.
* Exception filters captured unexpected errors and wrote them to a file.
* The application met all the specified objectives and was successfully uploaded to GitHub.

---

