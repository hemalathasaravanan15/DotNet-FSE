---

### **React Lab: officespacerentalapp – JSX and Inline Styling**

---

#### **Scenario**

This lab focuses on understanding and implementing **JSX (JavaScript XML)** in a React application. Students are expected to demonstrate the use of **JSX syntax**, **React DOM rendering**, **JavaScript expressions**, and **inline CSS styling**. The lab project titled `officespacerentalapp` displays details of office spaces in a dynamic way using JSX and React elements.

---

#### **Procedure**

1. **Create the React Project**

   A new React application named `officespacerentalapp` was initialized using:

   ```bash
   npx create-react-app officespacerentalapp
   ```

2. **Set Up Project Structure**

   * Navigated to the `src` directory.
   * Edited the `App.js` file to include JSX elements for rendering office space content.
   * Removed the default boilerplate code to customize the UI from scratch.

3. **Display Heading and Image using JSX**

   * Used JSX syntax to create an **HTML heading** element.
   * Rendered an **image** using JSX `img` tag and added appropriate `src` and `alt` attributes.
   * Demonstrated embedding of JSX elements inside React's return statement.

4. **Create and Use Office Object**

   * Created a single JavaScript object `office` with properties: `name`, `rent`, and `address`.
   * Rendered the object’s data using **JSX expressions** inside HTML-like tags.

5. **Create a List of Office Spaces**

   * Defined an **array of office objects**.
   * Used the **`.map()`** function to iterate over the array and render multiple office space cards dynamically.

6. **Apply Conditional Inline CSS Styling**

   * Used **inline styling in JSX** to dynamically set the **text color** of the `rent` value:

     * **Red** if the rent is below `60000`
     * **Green** if the rent is `60000` or above
   * The styling was done using a JavaScript expression embedded inside JSX.

7. **Run the Application**

   Started the React development server with:

   ```bash
   cd officespacerentalapp
   npm start
   ```

   The application opened automatically in the browser at:
   `http://localhost:3000`

---

#### **Outcome**






<img width="1365" height="718" alt="Screenshot 2025-08-03 095259" src="https://github.com/user-attachments/assets/db46432d-0107-4ca0-af19-6815f4d353b9" />





<img width="1344" height="710" alt="Screenshot 2025-08-03 095311" src="https://github.com/user-attachments/assets/1ac8e0f0-dcc4-49d3-b29c-acd113bf6a33" />





<img width="1261" height="601" alt="Screenshot 2025-08-03 095426" src="https://github.com/user-attachments/assets/8e131aaf-13ed-4773-90b4-f679dbfa126e" />



* JSX syntax was successfully used to render elements and attributes.
* JavaScript expressions were used within JSX for dynamic data binding.
* Inline conditional styling was applied to visually distinguish office rents.
* The application dynamically rendered **multiple office spaces** using `.map()`.
* React DOM updated in real time, validating JSX-based component rendering.

---
