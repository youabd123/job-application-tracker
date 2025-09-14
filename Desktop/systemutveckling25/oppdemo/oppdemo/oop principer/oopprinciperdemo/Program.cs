using System.Collections.Generic;
using OOPPrinciperDemo.Inheritance;
using OOPPrinciperDemo.Polymorphism;
using OOPPrinciperDemo.Encapsulation;
using OOPPrinciperDemo.Abstraction;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("=== OOP – fyra principer (C# Console) ===\n");

// 1) Arv
var car = new Car("Volvo");
var bike = new Bike("Crescent");
car.Move();
bike.Move();

Console.WriteLine();

// 2) Polymorfism
var shapes = new List<Shape>
{
    new Circle(3),
    new Rectangle(2, 5)
};

foreach (var s in shapes)
{
    s.Draw(); // Samma metodnamn, olika beteenden
}

Console.WriteLine();

// 3) Inkapsling
var user = new User("Ali");
user.SetPassword("hemligt123");
Console.WriteLine($"Check rätt lösenord: {user.CheckPassword("hemligt123")}");
Console.WriteLine($"Check fel lösenord: {user.CheckPassword("fel")}");
user.PrintInfo();

Console.WriteLine();

// 4) Abstraktion
PaymentMethod method = new CreditCard("1234");
method.Pay(199.90m);
method = new PayPal("ali@example.com");
method.Pay(59m);

Console.WriteLine("\n=== Klart ===");

