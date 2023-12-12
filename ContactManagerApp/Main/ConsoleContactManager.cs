// ConsoleContactManager.cs
using ContactManagerApp.Interfaces;
using System;

public class ConsoleContactManager : IContactManager
{
    private IContactRepository contactRepository;
    private IUserInterface userInterface;
    private IContactService contactService;

    public ConsoleContactManager(
        IContactRepository contactRepository,
        IUserInterface userInterface,
        IContactService contactService)
    {
        this.contactRepository = contactRepository;
        this.userInterface = userInterface;
        this.contactService = contactService;
    }

    public void Run()
    {
        while (true)
        {
            userInterface.DisplayMenu(); // Display the menu

            string choice = userInterface.GetUserInput(); // Get user choice

            switch (choice)
            {
                case "1":
                    contactService.AddContact(contactRepository.LoadContacts());
                    break;
                case "2":
                    contactService.ListContacts(contactRepository.LoadContacts());
                    break;
                case "3":
                    contactService.ShowContactDetails(contactRepository.LoadContacts());
                    break;
                case "4":
                    contactService.RemoveContact(contactRepository.LoadContacts());
                    break;
                case "5":
                    contactRepository.SaveContacts(contactRepository.LoadContacts()); // Save contacts before exiting
                    Environment.Exit(0);
                    break;
                default:
                    userInterface.ShowMessage("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
