###  **React Lab 1: Creating and Running a Basic React Application**

---

####  **Scenario**

As part of the React lab session, the objective was to understand the concept of **Single Page Applications (SPA)** and get hands-on experience by building a basic React application using `create-react-app`. The application should display a simple heading:
**“Welcome to the first session of React”**
This helps learners become familiar with setting up the React environment, editing components, and running the app locally.

---

####  **Procedure**

1. **React Setup**

   * Installed Node.js and NPM from the official website: [https://nodejs.org/en/download/](https://nodejs.org/en/download/)
   * Installed React globally using `create-react-app` tool:

     ```bash
     npm install -g create-react-app
     ```

2. **Creating a New React Project**

   * Created a new React application named `myfirstreact`:

     ```bash
     npx create-react-app myfirstreact
     ```
   * Navigated to the project folder:

     ```bash
     cd myfirstreact
     ```

3. **Editing the Application**

   * Opened the project in **Visual Studio Code**.
   * Navigated to `src/App.js` and replaced the existing content with:

     ```jsx
     import React from 'react';

     function App() {
       return (
         <div>
           <h1>Welcome to the first session of React</h1>
         </div>
       );
     }

     export default App;
     ```

4. **Running the Application**

   * Used the following command to start the development server:

     ```bash
     npm start
     ```
   * The application launched automatically in the browser at `http://localhost:3000`, displaying the heading as required.

5. **Uploading to GitHub**

   * Initialized a Git repository:

     ```bash
     git init
     git add .
     git commit -m "Initial commit - My first React app"
     ```
   * Created a new repository on GitHub named `myfirstreact` and linked it:

     ```bash
     git remote add origin https://github.com/your-username/myfirstreact.git
     git branch -M main
     git push -u origin main
     ```

---

####  **Outcome**




<img width="1365" height="713" alt="Screenshot 2025-07-24 102518" src="https://github.com/user-attachments/assets/8e0dd683-2994-4361-9e5d-a7d5d5df4ae4" />




* Successfully created and ran a simple React application.
* Displayed the heading message as intended.
* Gained experience with `create-react-app`, JSX editing, component usage, and GitHub deployment.

---
