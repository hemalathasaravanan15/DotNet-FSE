## Financial Forecasting

### Scenario:

You are building a financial forecasting tool that uses historical data and growth rates to predict future values. A recursive approach is used to simulate the calculation of values over time.

---

## Steps Followed:

### Step 1: Understand Recursive Algorithms

* Studied the concept of **recursion**, where a function calls itself to solve smaller instances of a problem.
* Recognized that recursion is useful for problems that can be broken down into sub-problems of the same nature, such as predicting values over multiple time periods.

### Step 2: Setup

* Defined a method to compute future values based on an initial amount and a consistent growth rate.
* Designed the method to apply the growth calculation repeatedly over the desired number of time periods.

### Step 3: Implementation

* Implemented a **recursive algorithm** to calculate the projected future value:

  * For each recursive step, the method multiplied the current value by the growth rate.
  * The recursion continued until the target number of periods was reached.
* This approach allowed the model to simulate compound growth over time.

### Step 4: Analysis

* Analyzed the **time complexity** of the recursive solution:

  * The basic recursive implementation had linear time complexity O(n), where *n* is the number of time periods.
* Discussed optimization strategies:

  * Identified the potential for **stack overflow** with deep recursion in large time periods.
  * Proposed optimization using **memoization** or converting the algorithm to an **iterative approach** to improve performance and avoid unnecessary recomputation.

---

## Outcome:

![financial forecasting](https://github.com/user-attachments/assets/3f3aaae0-c402-4d4b-8899-698ee705c63c)


A functional recursive model was developed to predict financial values. While recursion offered simplicity in implementation, its limitations for large datasets were acknowledged and addressed with potential improvements for real-world scalability.


