using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciperDemo.Abstraction;

public abstract class PaymentMethod
{
    public abstract void Pay(decimal amount);
}

public class CreditCard : PaymentMethod
{
    public string Last4 { get; }

    public CreditCard(string last4)
    {
        Last4 = last4;
    }

    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Betalar {amount:C} med kreditkort **** **** **** {Last4}");
    }
}

public class PayPal : PaymentMethod
{
    public string Email { get; }

    public PayPal(string email)
    {
        Email = email;
    }

    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Betalar {amount:C} via PayPal-konto {Email}");
    }
}

