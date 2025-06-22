## Implementing the Factory Method Pattern
## Scenario:
You are developing a document management system that must support the creation of various document types such as Word, PDF, and Excel. To achieve flexibility and maintainability, you implement the Factory Method Pattern.

## Steps Followed:
 
## Step 1: Project Setup
Created a new console application project named FactoryPattern.

Organized the code into appropriate class files within the project.

## Step 2: Define Document Abstraction
Defined a common interface or abstract class to represent a generic document.

This acts as a contract for all document types to implement a standard method (e.g., Open()).

## Step 3: Implement Concrete Document Classes
Created separate classes for each document type:

WordDocument

PdfDocument

ExcelDocument

Each class implements the common interface and provides specific behavior for opening the document.

## Step 4: Design the Factory Structure
Implemented an abstract DocumentFactory class containing a method like CreateDocument().

For each document type, created a corresponding concrete factory class:

WordDocumentFactory

PdfDocumentFactory

ExcelDocumentFactory

Each concrete factory overrides the creation method to return the appropriate document object.

## Step 5: Testing the Factory Method
In the main test class:

Instantiated each factory type.

Called the factory's CreateDocument() method to generate document objects.

Invoked the Open() method to verify the correct document behavior.

## Outcome:
![factory pattern](https://github.com/user-attachments/assets/8a4290d2-a1af-49d4-9c2c-b611516cab53)


The program successfully created and opened different types of documents using their respective factories.

Demonstrated the power of the Factory Method Pattern in achieving loose coupling and scalability.

