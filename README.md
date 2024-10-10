# Observer pattern - Real Estate Sales 🏠
 
## Introduction:
This project implements a real estate sales system. In this system, potential buyers can monitor the prices of properties they are interested in. They can set a target price at which they are willing to purchase the property, and the system will notify them if the price of the house increases, decreases, or falls below their specified amount. To enable potential buyers to observe these price changes, the Observer behavioral pattern has been utilized, allowing them to track and receive notifications about price fluctuations.

### The Observer pattern 👀
The Observer pattern is a behavioral design pattern that defines a one-to-many relationship between objects. In this pattern, an object (called the subject or observable) maintains a list of its dependents (called observers) and notifies them automatically of any state changes, usually by calling one of their methods. This pattern is useful when you want to ensure that a change in one object triggers updates in multiple other objects without tightly coupling them.

Key Components of the Observer Pattern

1.	Subject (Observable): The object that holds the state and sends notifications to observers when its state changes. It maintains a list of observers that are interested in being notified of changes.
2.	Observer: The interface or abstract class that defines the method(s) to be implemented by concrete observer classes. Observers register with the subject to receive updates.
3.	Concrete Subject: A specific implementation of the subject that contains the state and sends notifications to observers.
4.	Concrete Observer: A specific implementation of the observer that updates itself based on changes in the subject.

How It Works

1.	Registration: Observers register themselves with the subject to receive notifications.
2.	State Change: When the subject’s state changes, it triggers the notification process.
3.	Notification: The subject calls the update method on each registered observer, allowing them to react to the change.

Benefits

* Loose Coupling: The subject and observers are loosely coupled, meaning they can evolve independently. Observers can be added or removed without modifying the subject.
* Dynamic Relationships: You can add or remove observers at runtime, which makes the system flexible and adaptable.
* Single Source of Truth: The subject acts as a single source of truth, while observers react to its state.

Example Use Cases

* User Interfaces: UI components that need to update when the underlying data changes, such as in MVC (Model-View-Controller) architectures.
* Event Handling Systems: Systems where events need to trigger updates in multiple parts of an application, like in GUI frameworks.
* Real-Time Monitoring: Applications that need to monitor changes in data or state and notify various components accordingly, like stock price tracking apps.


## Class Diagram:
<div style="text-align:center"><img src="https://github.com/DussanFreire/RealEstateSelling/blob/main/Imagenes/diag.%20clases%20%20inmuebles.png" /></div>

## Sequence Diagram:
<div style="text-align:center"><img src="https://github.com/DussanFreire/RealEstateSelling/blob/main/Imagenes/Diag.%20de%20secuencia.png" /></div>
