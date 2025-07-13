
##  **Scenario**

You are an instrumentation student learning how to build a simple RESTful Web API using .NET Core. You want to:

1. Create an API project in Visual Studio Code.
2. Add a basic controller with Read/Write functionality.
3. Test the API using Swagger.
4. Push your completed project to GitHub for submission or collaboration.

---

## **Step-by-Step Procedure**

---

###  Step 1: **Open Visual Studio Code**

* Launch **Visual Studio Code** on your computer.
* Make sure you have the **.NET SDK** installed (v9.0 or appropriate version).
* Also install the **C# Extension** from the Extensions Marketplace.

---

###  Step 2: **Create a New .NET Web API Project**

* Open the **terminal** in VS Code.
* Use the `.NET CLI` to create a Web API project.
* The project will generate a folder with predefined structure:

  * `Controllers` folder
  * `Program.cs`
  * `appsettings.json`, etc.

---

###  Step 3: **Open the Project Folder**

* Go to `File > Open Folder` in VS Code.
* Choose the folder you just created.
* You’ll see the project files and folders in the **Explorer pane**.

---

### Step 4: **Understand the Folder Structure**

* `Controllers/`: Where API logic lives (e.g., `ValuesController`)
* `Program.cs`: Main entry point where the app is configured.
* `appsettings.json`: Configuration file (e.g., database connection, logging).
* `Properties/launchSettings.json`: Controls how the app is launched (e.g., port).

---

###  Step 5: **Run the Web API**

* Open the terminal inside VS Code.
* Run the command: `dotnet run`
* The terminal will display a message like:

  ```
  Now listening on: http://localhost:5000
  ```
* Open this link in your browser.

---

###  Step 6: **Open Swagger UI**

* Navigate to `http://localhost:5000/swagger`
* This opens **Swagger UI**, where you can:

  * Test GET and POST methods.
  * View how your API returns responses.

---

###  Step 7: **Test Your API**

* Click `GET /values` → Click **Execute** → You’ll get a sample response.
* If you add a `POST`, you can enter a value and click **Execute** to test it.
* Observe the JSON response and HTTP Status codes like `200 OK`.

---

###  Step 8: **Create a GitHub Repository**

* Go to [https://github.com](https://github.com) and log in.
* Click **New repository**

  * Give a name like `MyFirstWebAPI`
  * Add description (optional)
  * Keep it **public** or **private**
  * Click **Create repository**

---

###  Step 9: **Push Your Project to GitHub**

* Open a terminal in your project folder in VS Code.
* Run Git commands to initialize, add, commit, and push:

  * `git init`
  * `git add .`
  * `git commit -m "First Web API"`
  * `git remote add origin <your GitHub repo link>`
  * `git push -u origin master` or `main`

---

###  Step 10: **Verify GitHub Upload**

* Go to your GitHub repo in browser.
* Refresh — you’ll see all your project files uploaded.
* You can now share the link or continue developing.

---

##  Outcome:

<img width="1365" height="722" alt="Screenshot 2025-07-13 202133" src="https://github.com/user-attachments/assets/bdf14414-bde7-47e1-b7ab-70ae9bd35ebc" />


<img width="1365" height="717" alt="Screenshot 2025-07-13 202156" src="https://github.com/user-attachments/assets/2fa3aa1f-940c-4695-a276-a5ba00b2529e" />


<img width="1359" height="634" alt="Screenshot 2025-07-13 202450" src="https://github.com/user-attachments/assets/bac8029d-874e-44f8-ad20-ffc0854fda84" />


<img width="1363" height="713" alt="Screenshot 2025-07-13 202506" src="https://github.com/user-attachments/assets/fd623c75-5dbe-4246-a06e-ea1a1d25c5ee" />

 We now have:

* A working Web API with Read/Write endpoints.
* Swagger UI running for testing.
* A GitHub repository to showcase your work.

Let me know if you want a matching **Word or PDF report** for submission!
