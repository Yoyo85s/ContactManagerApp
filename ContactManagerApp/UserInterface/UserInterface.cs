// UserInterface.cs
using ContactManagerApp.Interfaces;
using System;

public class UserInterface : IUserInterface
{
    public string GetUserInput()
    {
        // Implement logic to get user input from console
        return Console.ReadLine();
    }

    public void DisplayMenu()
    {
        // Implement logic to display menu on console
        Console.WriteLine("1. Add Contact");
        Console.WriteLine("2. List Contacts");
        Console.WriteLine("3. Show Contact Details");
        Console.WriteLine("4. Remove Contact");
        Console.WriteLine("5. Exit");
        Console.Write("Choose an option: ");
    }

    public void ShowMessage(string message)
    {
        // Implement logic to show messages on console
        Console.WriteLine(message);
    }
}
