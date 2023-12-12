using ContactManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerApp.Interfaces
{
    public interface IContactService
    {
        
        void AddContact(List<Contact> contacts);
        void RemoveContact(List<Contact> contacts);
        void ListContacts(List<Contact> contacts);
        void ShowContactDetails(List<Contact> contacts);
        // ... other methods
    }
}
