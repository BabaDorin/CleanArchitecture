# Dealerhip Car Management | Clean Architecture implementation
### The most lightweight implementation of CA. 0 external libraries needed.

This project illustrates how we can use Clean Architecture to ensure Separation of Concerns. The idea behind Separation of Concerns principle is to separate the application into distinct sections, each section addressing a separate concern.

According to CA, the application can be separated into 4 different concerns:
- Presentation
  - It takes care about interacting with the client and might take the form of a Web API, Android / iOS / desktop application. In other words, it is the user interface.
- Application
  - Here is where our business resides. This layer is responsible for encapsulating all the business logic of our application. (More about what is business  logic can be found on the full version of this article, link in comments).
- Infrastructure:
  - handles the communication with the outer world. By outer world we mean database, file system, cloud services, message brokers, topics etc.
- Domain:
  - It contains domain models, entities, value objects and events. Usually, these are simple and do not have any logic inside (POCOs in C#, POJOs in Java).

These are the takeaways:
- Do not mix up concerns. You might end up with a spaghetti-like codebase (you don't want that),
- Keep components loosely coupled so you don't have to rebuilt the full application when you change only a tiny bit of it,
- Keep the business logic of your application decoupled from infrastructure (concrete databases, cloud services etc.) and your user interface,
- Having concerns separated results in a more maintainable and easy to understand codebase.
