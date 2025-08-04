---

### **React Lab: bloggerapp – Conditional Rendering & List Components**

---

#### **Scenario**

In this lab, the objective is to practice **various techniques of conditional rendering** and **handling list-based components using keys and the map() function**. The application consists of three components: **BookDetails**, **BlogDetails**, and **CourseDetails**. The rendering of these components is based on a flag or user selection.

---

#### **Procedure**

1. **Create the React Project**

   Created a new React app using the command:

   ```bash
   npx create-react-app bloggerapp
   ```

2. **Create Component Structure**

   Inside the `src` folder:

   * A new folder `components` was created.
   * Three components were added:

     * `BookDetails.js`
     * `BlogDetails.js`
     * `CourseDetails.js`

   Each component:

   * Declares a **list of items** (e.g., books, blogs, courses).
   * Uses the **`map()` function** to loop through and render items.
   * Applies **unique keys** for each rendered element.

3. **Implement Conditional Rendering in `App.js`**

   In `App.js`:

   * A **flag variable** (e.g., `displayComponent`) was defined using `useState` to decide which component to show.

   * Implemented **multiple conditional rendering techniques**:

     * **If-Else**
     * **Ternary operator**
     * **Short-circuit (&&) operator**
     * **Switch-case (optional for multiple views)**

   * Rendered only one component at a time based on the flag.

   * Buttons were provided to switch between Book, Blog, and Course components.

4. **Handle List Rendering with Keys**

   Inside each component:

   * A list of items (books, blogs, courses) was stored as an array of objects.
   * `map()` was used to render each item.
   * A **unique key** (like `id`) was assigned to each element for optimal rendering performance and debugging.

5. **Run the Application**

   Navigated to the project folder and started the development server:

   ```bash
   cd bloggerapp
   npm start
   ```

   The app opened in the browser at `http://localhost:3000`, and the user could switch between views using buttons, each displaying respective content using list rendering.

---

#### **Outcome**







<img width="1357" height="720" alt="Screenshot 2025-08-03 101826" src="https://github.com/user-attachments/assets/d2fa3fea-f722-4cf4-9c16-1c592d3f5f11" />






<img width="1358" height="708" alt="Screenshot 2025-08-03 101839" src="https://github.com/user-attachments/assets/e311cc3b-9b4c-4c49-ade4-c9325effcb0e" />







* Applied **multiple ways of conditional rendering** in a single project.
* Created and rendered **multiple components** based on state.
* Practiced use of **keys in list rendering** using `map()`.
* Created a modular, responsive app that switches between blog, book, and course views.

---
