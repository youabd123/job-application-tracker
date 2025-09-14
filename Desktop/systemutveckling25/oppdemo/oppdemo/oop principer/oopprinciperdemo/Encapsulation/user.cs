using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPPrinciperDemo.Encapsulation;

public class User
{
    public string Username { get; }
    private string _passwordHash = ""; // privat fält

    public User(string username)
    {
        Username = username;
    }

    public bool SetPassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
        {
            Console.WriteLine("Lösenordet måste vara minst 6 tecken.");
            return false;
        }

        // Enkel demo-"hash" (gör inte så här i skarp kod)
        _passwordHash = Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
        return true;
    }

    public bool CheckPassword(string password)
    {
        var tryHash = Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
        return tryHash == _passwordHash;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Användare: {Username}, Lösenord lagrat? {(_passwordHash != "" ? "Ja" : "Nej")}");
    }
}

