Exercise 1: Mail Sender Module with Moq
Scenario:
You are part of a team developing an application that sends emails to users upon every transaction. To test the email functionality efficiently—without actually sending emails—you decide to mock the external mail server dependency using Moq and write unit tests using the NUnit framework.

Steps Followed:
Step 1: Create Mail Sending Interface and Implementation
Created a Class Library project named CustomerCommLib in Visual Studio.

Defined an interface IMailSender with a method:

SendMail(string toAddress, string message)

Implemented this interface in a class called MailSender using:

System.Net

System.Net.Mail

The SendMail method was configured to:

Set SMTP server, port, sender credentials, subject, and body.

Send the email via Gmail SMTP.

Step 2: Design the Class Under Test
Created a class CustomerComm that depends on IMailSender.

Implemented constructor injection to pass in the dependency.

Inside the method SendMailToCustomer(), called SendMail(...) with hardcoded recipient and message.

This approach allowed loose coupling and made the class easier to test.

Step 3: Setup Unit Testing Project
Created a new Class Library project named CustomerComm.Tests.

Installed the following packages via NuGet:

NUnit

NUnit3TestAdapter

Moq

Added reference to CustomerCommLib.

Step 4: Write Unit Test Using Moq
Created a test class using [TestFixture].

Used [OneTimeSetUp] to:

Mock IMailSender using Moq.

Setup the mock to return true for any two string arguments.

Inject the mock into CustomerComm.

In the test method [TestCase], called SendMailToCustomer() and asserted the result to be true.

Outcome:
The module was successfully unit tested without relying on real email transmission. Using Moq helped simulate the behavior of IMailSender, ensuring test reliability and faster execution. The approach demonstrated best practices in dependency injection, mocking, and unit testing using NUnit.
