using ContactManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerApp.Interfaces
{
    public interface IContactRepository
    {
        List<Contact> LoadContacts();
        void SaveContacts(List<Contact> contacts);
    }
}
