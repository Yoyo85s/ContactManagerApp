// ContactService.cs
using ContactManagerApp.Interfaces;
using ContactManagerApp.Models;
using System;
using System.Collections.Generic;

public class ContactService : IContactService
{
    public void AddContact(List<Contact> contacts)
    {
        Contact newContact = Contact.CreateContactFromUserInput();
        contacts.Add(newContact);
        // Implement logic to add a contact
    }

    public void ListContacts(List<Contact> contacts)
    {

        // Implement logic to list contacts
        if (contacts.Count > 0)
        {
            Console.WriteLine("List of Contacts:");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.FirstName} {contact.LastName} - {contact.Email}");
            }
        }
        else
        {
            Console.WriteLine("No contacts available.");
        }
    }

    public void ShowContactDetails(List<Contact> contacts)
    {
        // Implement logic to show contact details
        // Implementation of ShowContactDetails
        // Use userInterface to get the email input from the user
        Console.WriteLine("Enter the email address of the contact:");
        string email = Console.ReadLine();

        Contact contact = contacts.Find(c => c.Email == email);

        if (contact != null)
        {
            Console.WriteLine($"Details for {contact.FirstName} {contact.LastName}:");
            Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
            Console.WriteLine($"Email: {contact.Email}");
            Console.WriteLine($"Address: {contact.Address}");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    public void RemoveContact(List<Contact> contacts)
    {
        // Implement logic to remove a contact
        // Implementation of RemoveContact
        Console.WriteLine("Enter the email address of the contact to remove:");
        string email = Console.ReadLine();

        Contact contactToRemove = contacts.Find(c => c.Email == email);

        if (contactToRemove != null)
        {
            contacts.Remove(contactToRemove);
            Console.WriteLine($"Contact {contactToRemove.FirstName} {contactToRemove.LastName} removed.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }
}
