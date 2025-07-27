

### **React Lab: Score Calculator App – Functional Component and Styling**

---

#### **Scenario**

In this lab session, the objective is to explore **React functional components** and apply basic **styling using external CSS**. A new application named **`scorecalculatorapp`** is created to build a component that calculates and displays the average score of a student based on the total marks and goal provided. This practical task demonstrates the use of **props**, **JSX expressions**, and **component-level styling** in React.

---

#### **Procedure**

1. **Create the React Project**

   * A new React project named `scorecalculatorapp` was created using the following command:

     ```bash
     npx create-react-app scorecalculatorapp
     ```

2. **Create a Component Folder**

   * Inside the `src` directory, a new folder named `Components` was created.
   * A file named `CalculateScore.js` was added to this folder.
   * The file contains a **functional component** that:

     * Accepts `Name`, `School`, `Total`, and `Goal` as props
     * Calculates the average score using basic logic
     * Displays all student details including the calculated average

3. **Create and Apply External Styles**

   * A new folder named `Stylesheets` was created under `src`.
   * A CSS file named `mystyle.css` was created and used to style the `CalculateScore` component.
   * The component was updated to import this CSS file and apply relevant class-based styles.

4. **Edit `App.js` to Render the Functional Component**

   * The `CalculateScore` component was imported into `App.js`.
   * Sample data (Name, School, Total, Goal) was passed as props.
   * The component was rendered inside the main App component to display output.

5. **Run the Application**

   * In the terminal, navigated to the project folder:

     ```bash
     cd scorecalculatorapp
     ```
   * Started the development server using:

     ```bash
     npm start
     ```
   * The application opened in the browser at `http://localhost:3000` displaying the calculated average and student details.

---

#### **Outcome**







<img width="1365" height="716" alt="Screenshot 2025-07-24 110238" src="https://github.com/user-attachments/assets/a655d62a-c24f-4f5f-af3b-5172091a0878" />





<img width="1358" height="713" alt="Screenshot 2025-07-24 110252" src="https://github.com/user-attachments/assets/78d5a849-88cf-41b7-9eef-f48adf20138d" />





* A functional component `CalculateScore` was created and rendered successfully.
* External CSS was applied to enhance component styling.
* The component correctly displayed the student’s name, school, total score, goal, and calculated average.
* The project met all learning goals related to functional components, props usage, styling, and JSX rendering in React.

---

