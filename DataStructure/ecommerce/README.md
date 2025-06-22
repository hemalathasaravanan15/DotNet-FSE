## E-commerce Platform Search Function
## Scenario:
You are developing the search functionality of an e-commerce platform. The goal is to optimize the search operation for speed and efficiency in retrieving product details.

## Steps Followed:
## Step 1: Understand Asymptotic Notation
Reviewed the concept of Big O notation, which is used to describe the performance of an algorithm in terms of input size.

Explained how Big O helps analyze the time and space complexity of algorithms.

Discussed the best-case, average-case, and worst-case scenarios for search operations:

Best case: the item is found at the beginning.

Average case: the item is somewhere in the middle.

Worst case: the item is not found or is at the end.

## Step 2: Setup
Created a Product class to represent individual items in the system.

Included relevant attributes such as productId, productName, and category.

Prepared data collections using arrays to simulate the product database.

## Step 3: Implementation
Implemented two search algorithms:

Linear Search: iterates through the array one item at a time to find a match.

Binary Search: operates on a sorted array and repeatedly divides the search range in half until the item is found or determined to be missing.

Products were stored in:

An unsorted array for linear search.

A sorted array for binary search based on productName.

## Step 4: Analysis
Compared the time complexity of both algorithms:

Linear search: O(n)

Binary search: O(log n)

Discussed that:

Linear search is suitable for small or unsorted data sets.

Binary search is more efficient for large, sorted datasets and is recommended for performance-critical applications like e-commerce platforms.

## Outcome:
![ecommerce](https://github.com/user-attachments/assets/a932474a-156a-4daf-970c-4263646c55be)

Both search methods were successfully implemented and tested. Binary search demonstrated significantly better performance for larger and sorted product lists, making it the more appropriate choice for the e-commerce platform's search feature.
