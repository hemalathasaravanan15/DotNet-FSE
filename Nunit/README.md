Exercise: Unit Testing with NUnit - TestFixture & TestCase
Scenario:
You are provided with a calculator application in a class library (CalcLibrary). Your task is to write unit test cases using NUnit framework to validate the calculator methods. You will focus on testing the addition functionality, using attributes like TestFixture, SetUp, TearDown, and TestCase.

Steps Followed:
Step 1: Setup the Testing Environment
Downloaded and opened the provided solution in Visual Studio.

Created a Unit Test Project (.NET Framework) within the same solution to hold the test cases.

Named the test project appropriately (e.g., CalcLibrary.Tests).

Step 2: Reference the Calculator Logic
Added a reference to the CalcLibrary project in the test project.

This allows the test class to access and test the methods inside the calculator logic.

Step 3: Configure NUnit for Testing
Installed necessary NuGet packages:

NUnit for writing the tests.

NUnit3TestAdapter for integrating with the Visual Studio Test Explorer.

Ensured the test framework is properly configured to run and display results.

Step 4: Create the Test Class
Created a test class and marked it with the [TestFixture] attribute to denote that it contains test methods.

Used [SetUp] to initialize required test objects or instances before each test case runs.

Used [TearDown] to perform cleanup after each test case execution, maintaining test independence.

Step 5: Write Test Method for Addition
Created a test method specifically to test the addition functionality.

Applied the [TestCase] attribute to define multiple input scenarios and their expected results.

Used assertions to compare the actual output from the method with the expected result provided.

Step 6: Execute and Verify
Ran the tests using Test Explorer in Visual Studio.

Verified that all test cases passed and accurately validated the addition method.

Confirmed that the structure of setup and teardown maintained consistent test state across runs.

Outcome:

![Nunit output](https://github.com/user-attachments/assets/da02e713-e981-4188-819f-57d384fb3c8e)

The addition method of the calculator was successfully tested using NUnit. The process ensured:

Clear separation of logic and tests.

Structured, repeatable test execution.

Efficient test management using TestFixture, SetUp, TearDown, and TestCase.

This exercise demonstrated the power of automated unit testing and good testing practices in .NET development.




