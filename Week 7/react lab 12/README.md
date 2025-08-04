---

### **React Lab: ticketbookingapp – Conditional Rendering in React**

---

#### **Scenario**

This lab demonstrates how to implement **conditional rendering** in React using **element variables**, **simple conditions**, and **logical control**. The app simulates a basic **ticket booking portal** where **guest users** can only view flights, while **logged-in users** can book tickets.

---

#### **Procedure**

1. **Create the React Project**

   The React application was created using the following command:

   ```bash
   npx create-react-app ticketbookingapp
   ```

2. **Set Up Component Structure**

   Inside the `src` folder:

   * Created two components:

     * `GuestPage.js` – displays flight details only.
     * `UserPage.js` – allows booking tickets.
   * Each component includes JSX to show a distinct layout and message for the user type.

3. **Implement Conditional Rendering in `App.js`**

   * A state variable `isLoggedIn` was created using the `useState` hook to determine the login status.
   * Based on the value of `isLoggedIn`, either:

     * `<UserPage />` is rendered when the user is logged in.
     * `<GuestPage />` is rendered when the user is not logged in.
   * The conditional logic was handled using **if-else**, **ternary operator**, or **element variables**.

4. **Add Login and Logout Buttons**

   * Two buttons were created:

     * **Login** – Sets `isLoggedIn` to `true`
     * **Logout** – Sets `isLoggedIn` to `false`
   * These buttons toggle the view dynamically based on the current login state.

5. **Run the Application**

   Navigated to the project folder and started the development server:

   ```bash
   cd ticketbookingapp
   npm start
   ```

   The app opened in the browser at `http://localhost:3000`, showing different views for guest and user modes.

---

#### **Outcome**



<img width="1365" height="716" alt="Screenshot 2025-08-03 100833" src="https://github.com/user-attachments/assets/1b4097f7-519d-4a65-9911-2ff9a51a4423" />





<img width="1357" height="707" alt="Screenshot 2025-08-03 100845" src="https://github.com/user-attachments/assets/feb46ead-76ad-46ea-b0b9-7da9f26c4f03" />






<img width="1353" height="703" alt="Screenshot 2025-08-03 100855" src="https://github.com/user-attachments/assets/93619366-fcc5-4e14-a714-253e0fff9535" />





* Successfully implemented **conditional rendering** using:

  * Element variables
  * `if-else` logic
  * JSX expressions
* Handled user state changes via buttons.
* Prevented components from rendering based on login state.
* Simulated a real-world use case of login-based user interface control.

-up too.
