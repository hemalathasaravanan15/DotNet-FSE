
---

### **React Lab: eventexamplesapp – Event Handling and Synthetic Events**

---

#### **Scenario**

This lab explores how to implement **event handling** in React using **event handlers**, the **`this` keyword**, and **synthetic events**. The app also demonstrates how to interact with buttons and form elements using React’s **event naming conventions**. A real-world example of a **currency converter** is also built as part of this lab.

---

#### **Procedure**

1. **Create the React Project**

   The React application was initialized using:

   ```bash
   npx create-react-app eventexamplesapp
   ```

2. **Build Counter Functionality with Multiple Event Handlers**

   * Inside `App.js`, a **state variable `count`** was declared using `useState` hook to track the counter value.
   * Two buttons were created:

     * **"Increment"**: Calls two methods when clicked:

       * Increments the count
       * Logs a greeting message to the console (`Hello! This is a static message.`)
     * **"Decrement"**: Decreases the count using a single handler function.

3. **Implement a Button with Argument-based Event Handling**

   * A button labeled **"Say Welcome"** was added.
   * It calls a function with an argument (e.g., `"Welcome to the event handling example!"`).
   * This demonstrates passing custom arguments to event handler functions.

4. **Demonstrate Synthetic Events**

   * Created a button labeled **"OnPress"**.
   * On clicking, it triggers a **synthetic event** that logs or displays the message:
     **"I was clicked"**
   * This confirms the event was handled by React’s `SyntheticEvent` system (not the browser's native event).

5. **Create a CurrencyConverter Component**

   * A new component named `CurrencyConverter` was created inside the `src/Components` folder.
   * It includes:

     * A controlled input field to enter INR amount.
     * A **Convert** button that triggers `handleSubmit` method.
     * The logic converts the input into **Euros** using a fixed conversion rate (e.g., 1 Euro = 90 INR).
   * JSX was used to display both input and result cleanly.
   * The `handleSubmit` method was bound to the **onClick** event of the Convert button.

6. **Render Components in App**

   * The `CurrencyConverter` component was imported and rendered inside `App.js` along with the counter and buttons.
   * Each button and action was clearly labeled and handled using proper event names like `onClick`.

7. **Run the App**

   ```bash
   cd eventexamplesapp
   npm start
   ```

   Opened at: `http://localhost:3000`

---

#### **Outcome**


<img width="1363" height="714" alt="Screenshot 2025-08-03 100302" src="https://github.com/user-attachments/assets/f5055480-16ce-4c5b-85f4-64db3add3c84" />








<img width="1357" height="711" alt="Screenshot 2025-08-03 100328" src="https://github.com/user-attachments/assets/19c2cb01-51b2-4011-abf4-9042aa3059d7" />






<img width="1354" height="709" alt="Screenshot 2025-08-03 100341" src="https://github.com/user-attachments/assets/0206443e-0b9f-4a72-8bcc-f2e739b60123" />






* Successfully handled events in React using `onClick` and functional methods.
* Applied **multiple function calls** in a single event.
* Used **synthetic events** to manage click actions in a React-friendly way.
* Passed **custom arguments** to event handlers.
* Built and displayed a **currency converter** using a custom component.
* Practiced React’s naming conventions, JSX usage, and state management.

---

