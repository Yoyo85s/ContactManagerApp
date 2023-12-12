using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerApp.Interfaces
{
    public interface IUserInterface
    {
        void ShowMessage(string message);
        // ... other methods
        string GetUserInput();
        // ... other methods
        void DisplayMenu();
        // ... other methods
    }
}
