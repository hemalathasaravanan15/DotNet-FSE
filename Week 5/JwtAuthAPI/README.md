### ** Implementing JWT Authentication in ASP.NET Core Web API**

---

####  **Scenario**

In a microservice architecture, securing APIs is crucial for preventing unauthorized access. In this task, the goal is to implement **JWT (JSON Web Token)** based authentication in an ASP.NET Core Web API project. A login endpoint will generate a secure token for valid users, and certain endpoints will be protected such that only authenticated users can access them using that token.

---

####  **Procedure**

1. **Project Setup**

   * A new ASP.NET Core Web API project was created using the .NET CLI.
   * Necessary dependencies were added, including the `Microsoft.AspNetCore.Authentication.JwtBearer` package to enable JWT authentication.

2. **Configuration**

   * Application settings were updated to include a `Jwt` section in `appsettings.json`, defining:

     * A secret signing key
     * Issuer and audience identifiers
     * Token expiration duration

3. **Authentication Configuration**

   * In `Program.cs`, the JWT authentication scheme was added using `AddAuthentication()` and `AddJwtBearer()`.
   * Token validation parameters were configured to validate the issuer, audience, token lifetime, and signing key.

4. **Login Endpoint**

   * A controller (`AuthController`) was created with a POST method (`/api/auth/login`) to receive user credentials.
   * Upon successful validation (mocked for demo), a JWT token was generated and returned to the client.

5. **Protected API Endpoint**

   * Another controller (`ProtectedController`) was added with two endpoints:

     * `/api/protected/public` – accessible to everyone
     * `/api/protected/data` – secured with the `[Authorize]` attribute; requires a valid JWT token.

6. **Testing**

   * The endpoints were tested using **Swagger UI** and **Postman**.
   * The login token was retrieved via `/api/auth/login` and used in the `Authorization` header (`Bearer <token>`) to access the protected route.

---

####  **Outcome**

<img width="1357" height="715" alt="Screenshot 2025-07-20 231950" src="https://github.com/user-attachments/assets/15ede3dd-6ec7-4edb-9a93-2afbd83e6e4f" />


<img width="1365" height="713" alt="Screenshot 2025-07-20 232236" src="https://github.com/user-attachments/assets/1063a32c-6499-4a33-962d-4c60b273ad45" />


<img width="1365" height="718" alt="Screenshot 2025-07-20 232347" src="https://github.com/user-attachments/assets/cc0491da-9b09-4db7-9d8b-127075a67f08" />  


<img width="1365" height="720" alt="Screenshot 2025-07-20 233547" src="https://github.com/user-attachments/assets/837babd7-7284-4e7c-a969-1245d39194dc" />




* Successfully implemented JWT authentication in ASP.NET Core Web API.
* Valid users can obtain tokens and access protected resources.
* Unauthenticated requests are denied with `401 Unauthorized`.

---

