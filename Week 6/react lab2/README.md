

### **React Lab: Student Management Portal – Components Practice**

---

#### **Scenario**

This lab aims to provide hands-on experience with **React components** by building a simple **Student Management Portal**. The goal is to understand how to create and render multiple components using both **class-based** and **functional** approaches in a structured React project.

The portal includes three components:

* `Home`: Displays “Welcome to the Home page of Student Management Portal”
* `About`: Displays “Welcome to the About page of the Student Management Portal”
* `Contact`: Displays “Welcome to the Contact page of the Student Management Portal”

---

#### **Procedure**

1. **Create the React Project**

   * A new React project was initialized with the name `StudentApp` using the following command in the terminal:

     ```bash
     npx create-react-app StudentApp
     ```

2. **Set Up Component Folder Structure**

   * A new folder named `Components` was created inside the `src` directory to keep component files organized.

3. **Create `Home` Component**

   * A file named `Home.js` was added inside the `Components` folder.
   * The file contains a class component displaying a welcome message for the Home page.

4. **Create `About` and `Contact` Components**

   * Two more files, `About.js` and `Contact.js`, were created inside the same `Components` folder.
   * Each component (either class-based or functional) displays a relevant welcome message for the respective page.

5. **Edit `App.js` to Render All Components**

   * All three components were imported into `App.js`.
   * They were rendered in sequence inside the main `App` component to be displayed together on the homepage.

6. **Run the Application**

   * The following command was used to start the development server:

     ```bash
     npm start
     ```
   * The app automatically launched in the default browser at `http://localhost:3000`.

---

#### **Outcome**



<img width="1365" height="718" alt="Screenshot 2025-07-24 104404" src="https://github.com/user-attachments/assets/d6112a26-2cd4-4a5c-8eca-ca87ebbd9ec1" />





<img width="1358" height="715" alt="Screenshot 2025-07-24 104415" src="https://github.com/user-attachments/assets/c23d96af-25ae-40ca-814b-c304c7d9730f" />



* Successfully created a structured React app named `StudentApp`.
* Created and rendered multiple components (`Home`, `About`, and `Contact`).
* Learned the differences between class components and function components.
* Verified output locally in the browser with appropriate component messages.

---

