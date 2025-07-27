

---

### **React Lab: blogapp – Understanding Component Lifecycle Methods**

---

#### **Scenario**

In this lab, the goal is to understand and implement **React class component lifecycle methods** using a practical example named `blogapp`. A component named `Posts` will fetch a list of blog posts from an external API, handle the rendering of that data, and also handle any potential errors gracefully. This lab demonstrates the importance of lifecycle hooks such as `componentDidMount()` and `componentDidCatch()` in real-time data-driven applications.

---

#### **Objectives**

* Understand the need and benefits of the React component lifecycle.
* Identify key lifecycle hook methods such as `componentDidMount()` and `componentDidCatch()`.
* Learn the sequence of lifecycle events that occur during the mounting, updating, and unmounting phases of a component.
* Practice rendering content conditionally based on data loaded during a lifecycle phase.

---

#### **Procedure**

1. **Create the React Project**

   * A new React application named `blogapp` was created using the command:

     ```bash
     npx create-react-app blogapp
     ```

2. **Open Project in Visual Studio Code**

   * The project folder was opened in VS Code for component development.

3. **Create the Post Class (Data Model)**

   * A new file `Post.js` was created in the `src` directory.
   * The file defines a basic JavaScript class for holding post properties such as `userId`, `id`, `title`, and `body`.

4. **Create the `Posts` Component**

   * A class-based React component was created in `Posts.js`.
   * The constructor was defined to initialize the component’s state with an empty `posts` array.

5. **Define `loadPosts()` Method**

   * This method uses the Fetch API to retrieve data from the endpoint:

     ```
     https://jsonplaceholder.typicode.com/posts
     ```
   * The retrieved data is parsed and stored in the component’s state.

6. **Use `componentDidMount()` Lifecycle Hook**

   * The `componentDidMount()` method was implemented to call `loadPosts()` immediately after the component is mounted.
   * This ensures that the post data is fetched and displayed after the initial render.

7. **Render Post Data**

   * The `render()` method was implemented to loop through the `posts` in the state and display each post’s title and body using appropriate HTML elements like `<h2>` and `<p>`.

8. **Implement `componentDidCatch()`**

   * A custom `componentDidCatch()` method was added to handle unexpected rendering or network errors.
   * In case of any error, an alert message is displayed to the user.

9. **Render Posts Component in App**

   * The `Posts` component was imported into `App.js` and included in the component tree so it loads when the application runs.

10. **Run the Application**

    * The project was started using:

      ```bash
      npm start
      ```
    * The application loaded in the browser at `http://localhost:3000`, displaying the fetched posts dynamically.

---

#### **Outcome**



<img width="1365" height="719" alt="Screenshot 2025-07-24 111854" src="https://github.com/user-attachments/assets/821bf188-6c4a-483c-b48f-f918e5d1120a" />





<img width="1364" height="709" alt="Screenshot 2025-07-24 111905" src="https://github.com/user-attachments/assets/2ee0ca33-e06d-4bb0-91b0-6dfb35eb92ca" />


* Successfully created a functional blog application using React class components.
* Understood and implemented key lifecycle methods like `componentDidMount()` and `componentDidCatch()`.
* Learned how to fetch and display external data inside a component and manage it via state.
* Handled potential runtime errors using lifecycle hooks for more robust application behavior.

---
