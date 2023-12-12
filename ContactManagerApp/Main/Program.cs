// Program.cs
using ContactManagerApp.Interfaces;
using System;

class Program
{
    static void Main()
    {
        // Instantiate necessary components
        IContactRepository contactRepository = new ContactRepository("contacts.json");
        IUserInterface userInterface = new UserInterface();
        IContactService contactService = new ContactService();

        // Create an instance of the ContactManager
        IContactManager contactManager = new ConsoleContactManager(contactRepository, userInterface, contactService);

        // Run the application
        contactManager.Run();
    }
}
