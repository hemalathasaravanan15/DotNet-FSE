
---

### **React Lab: Styling Cohort Dashboard Using CSS Modules and Inline Styles**

---

#### **Scenario**

As part of the MyAcademy team at Cognizant, you’ve been assigned to style the dashboard that displays details of ongoing and completed cohorts. The dashboard is implemented as a React application, and your task is to enhance the UI by applying modular CSS and inline styling techniques to a React component that shows cohort information.

---

#### **Objectives**

* Understand the need for styling React components to improve usability and user experience.
* Learn how to work with **CSS Modules** for scoped styling.
* Apply both **CSS class-based** and **inline styles** in React.

---

#### **Procedure**

1. **Set Up the React Application**

   * The pre-built React application was downloaded and unzipped.
   * In Command Prompt, navigated to the root folder of the application.
   * Ran the following command to install and restore required `node_modules`:

     ```bash
     npm install
     ```

2. **Open in Visual Studio Code**

   * Opened the project folder using Visual Studio Code for development and styling.

3. **Create CSS Module**

   * A new CSS Module file named `CohortDetails.module.css` was created inside the `src` folder (or alongside the component).
   * A class named `.box` was defined with the following styles:

     * Width: 300px
     * Display: inline-block
     * Margin: 10px
     * Padding: 10px (top and bottom), 20px (left and right)
     * Border: 1px solid black
     * Border-radius: 10px

4. **Define a Style for `<dt>` Elements**

   * A tag selector for `dt` elements was defined inside the CSS Module to apply:

     * `font-weight: 500`

5. **Apply CSS Module to the Component**

   * The cohort details component file was updated to:

     * Import the `CohortDetails.module.css` file.
     * Apply the `box` class to the container `<div>` using `className={styles.box}`.

6. **Apply Conditional Inline Styling**

   * In the component’s `render` method or function body:

     * An inline style was applied to the `<h3>` element based on the cohort status:

       * Green text for `"ongoing"` status.
       * Blue text for `"completed"` or any other status.

7. **Run the Application**

   * Used the following command to run the React app:

     ```bash
     npm start
     ```
   * Opened the application in the browser at `http://localhost:3000`.

---

#### **Outcome**





<img width="1365" height="722" alt="Screenshot 2025-07-24 113603" src="https://github.com/user-attachments/assets/a7693aba-7b09-4202-bc45-86f3654aff01" />






<img width="1365" height="712" alt="Screenshot 2025-07-24 113616" src="https://github.com/user-attachments/assets/2b68bc0f-dabe-4e3c-a141-a63f6651216e" />


* Successfully implemented styling using both **CSS Modules** and **inline style logic**.
* Cohort details were displayed inside styled containers (`.box` class).
* Each `<dt>` label had a bold appearance using a scoped CSS rule.
* Cohort status headings dynamically reflected the appropriate color based on logic (green for ongoing, blue otherwise).
* Final result matched the expected layout and styling as described in the lab.

---
