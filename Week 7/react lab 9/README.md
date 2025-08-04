
---

### **React Lab 9: cricketapp – ES6 Features & Conditional Rendering**

---

#### **Scenario**

This lab focuses on **applying ES6 JavaScript features in a React environment**. The objective is to explore concepts such as **arrow functions**, **map()**, **destructuring**, and **array merging**, while practicing **conditional rendering in React**. The application named `cricketapp` uses two main components – `ListofPlayers` and `IndianPlayers` – to display and manipulate cricket player data.

---

#### **Procedure**

1. **Create the React Project**

   A new React project named `cricketapp` was initialized using:

   ```bash
   npx create-react-app cricketapp
   ```

2. **Create Component Files**

   Inside the `src` folder:

   * A folder named `Components` was created.
   * Two functional component files were created: `ListofPlayers.js` and `IndianPlayers.js`.

3. **Develop `ListofPlayers` Component**

   * An array of 11 players with `name` and `score` was declared.
   * The **`map()`** method was used to render each player’s information.
   * **Arrow functions** were used to filter and display only players with scores below 70.

4. **Develop `IndianPlayers` Component**

   * Players were divided into **odd and even index players** using array destructuring.
   * Two separate arrays, `T20players` and `RanjiTrophyPlayers`, were merged using the ES6 **spread operator** and displayed as a single list.

5. **Implement Conditional Rendering**

   * A flag variable (`flag = true` or `false`) was declared in `App.js`.
   * Used a simple `if-else` to display either the `ListofPlayers` or the `IndianPlayers` component on the homepage based on the flag value.

6. **Run the Application**

   Navigate to the project directory and start the development server:

   ```bash
   cd cricketapp
   npm start
   ```

   Open `http://localhost:3000` in the browser to view the results.

---

#### **Outcome**


<img width="1365" height="716" alt="Screenshot 2025-08-03 094602" src="https://github.com/user-attachments/assets/8ead9218-9bf4-495c-a099-725f0b673181" />





<img width="1365" height="669" alt="Screenshot 2025-08-03 094617" src="https://github.com/user-attachments/assets/cd93cc2e-09ac-424b-99e6-51d8eeb2fb79" />




<img width="1365" height="712" alt="Screenshot 2025-08-03 094714" src="https://github.com/user-attachments/assets/740af7fe-5686-4d72-b10a-bc81e917b3b0" />


* **ListofPlayers** displayed player details using `map()` and conditionally filtered low-scoring players using **arrow functions**.
* **IndianPlayers** demonstrated ES6 **destructuring** and **array merging** with conditional display of even/odd players.
* The application showcased **conditional rendering** based on the `flag` variable.
* All components followed **modern ES6+ syntax** within a React project structure.

---


