 Implementing the Singleton Pattern

## Scenario:

You need to ensure that a logging utility class in your application has only one instance throughout the application lifecycle to provide consistent and centralized logging.


## Steps Followed:

### Step 1: Create a New C# Project

* A new C# Console Application project was created and named `SingletonPatternExample`.
* All necessary class files were organized within this project structure.

### Step 2: Define a Singleton Class

* A class named `Logger` was created to represent the logging utility.
* A private static instance of the `Logger` class was declared to ensure a single point of access.
* The constructor of the `Logger` class was made private to prevent direct instantiation from outside the class.
* A public static method was implemented to provide controlled access to the single instance of the `Logger`.

### Step 3: Implement the Singleton Pattern

* The Singleton design pattern was implemented to ensure that only one instance of the `Logger` class exists.
* Lazy initialization or early instantiation techniques were considered based on thread safety and performance requirements.

### Step 4: Test the Singleton Implementation

* A test class was created with multiple calls to the logger instance.
* Logging was performed using the shared instance to verify that all calls reference the same object.
* Object references were compared to confirm that only one instance was created and used throughout the program.



## Outcome:

![singleton pattern](https://github.com/user-attachments/assets/587a2435-ff5d-420d-b6c3-310d0c13247d)

The Singleton Pattern was successfully implemented, ensuring that all logging activities in the application used a single consistent instance of the `Logger` class. This design improves resource usage and maintains centralized control over logging.


