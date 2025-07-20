## Scenario
You are tasked with building a basic chat messaging system where Kafka acts as the communication backbone. Messages sent by a user are pushed to a Kafka topic and consumed by other users in real time. This exercise includes two types of client applications: a console-based command-line application and a graphical Windows Forms application. Both leverage Kafka to send and receive messages.

## Hands-On Tasks
## Task 1: Console-Based Kafka Chat Application
## Objective
Create a console-based chat system where one user acts as a Kafka producer and another as a consumer. This demonstrates the basic Kafka messaging flow using .NET.

## Procedure
Install Apache Kafka and Zookeeper

Download the Kafka binary release.

Extract and place it in a simple path (e.g., C:\kafka).

Start Zookeeper using zookeeper-server-start.bat.

Start the Kafka broker using kafka-server-start.bat.

Create Kafka Topic

Use Kafka CLI to create a topic named chat-topic.

Set Up C# Console Applications

Create two separate .NET console apps: ChatProducer and ChatConsumer.

Install the Confluent.Kafka NuGet package in both projects.

Implement Producer Logic

Connect to the Kafka broker.

Accept user input and publish to chat-topic.

Implement Consumer Logic

Connect to the Kafka broker.

Continuously poll for messages from chat-topic and display them on the console.

Run and Test

Run ChatConsumer in one terminal.

Run ChatProducer in another.

Send messages from the producer and see them appear in the consumer console.

## Expected Outcome

Messages typed into the producer console are successfully delivered to Kafka and appear in real-time on the consumer console.

This demonstrates Kafka's asynchronous message delivery in a basic environment.

## Task 2: Windows Forms Kafka Chat Application
## Objective
Build a graphical chat client using Windows Forms and integrate Kafka producer/consumer logic. Multiple instances of the application will act as separate chat clients.

## Procedure
Set Up a Windows Forms App

Create a new Windows Forms App (.NET) project in Visual Studio.

Add necessary controls: input textbox, display textbox, send button.

Install Kafka Client

Install Confluent.Kafka via NuGet.

Implement Kafka Producer

Configure the producer to send messages when the send button is clicked.

Implement Kafka Consumer

Use a background thread to continuously consume messages from chat-topic.

Update the chat display area using thread-safe UI calls.

Run Multiple Instances

Run multiple builds of the Windows Forms application.

Each window behaves as a separate chat user.

Send and Receive Messages

Messages sent from one window should appear in all other running instances.

## Expected Outcome
Users can interact with the chat system via a user-friendly graphical interface.

Messages sent by one instance are delivered via Kafka and consumed by others in real-time.

Demonstrates real-world usage of Kafka in distributed GUI applications.

## Sender

<img width="1365" height="714" alt="sender" src="https://github.com/user-attachments/assets/1d4a80e8-e07e-4fdf-a8f3-c9257b743be7" />

## Receiver 

<img width="1365" height="719" alt="receiver" src="https://github.com/user-attachments/assets/939bd5cd-dcef-4119-8382-074012bbd3e9" />

## Kafka Server Running

<img width="1365" height="714" alt="kafka server" src="https://github.com/user-attachments/assets/8194b172-3d7d-4d3f-b1c9-b6f4a8fe4031" />

## ZooKeeper Running

<img width="1362" height="718" alt="zookeeper" src="https://github.com/user-attachments/assets/5a839eaf-8d35-489e-a188-6cc883c72d97" />

