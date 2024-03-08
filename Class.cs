using System;

namespace Domain;
public class Money
{
    public int Dollars { get; set; }
    public int Cents { get; set; }

    public Money(int dollars, int cents)
    {
        Dollars = dollars;
        Cents = cents;
    }

    // Метод для виведення суми на екран
    public void DisplayAmount()
    {
        Console.WriteLine($"Total amount: {Dollars}.{Cents:D2}");
    }

    // Метод для зменшення суми на вказану кількість
    public void DecreaseAmount(int dollars, int cents)
    {
        if (dollars > Dollars || (dollars == Dollars && cents > Cents))
        {
            Console.WriteLine("Cannot decrease amount. Insufficient funds.");
        }
        else
        {
            Dollars -= dollars;
            if (cents > Cents)
            {
                Dollars -= 1;
                Cents = 100 - (cents - Cents);
            }
            else
            {
                Cents -= cents;
            }
            Console.WriteLine("Amount decreased successfully.");
        }
    }
}

public class Product
{
    public string Name { get; set; }
    public Money Price { get; set; }

    public Product(string name, Money price)
    {
        Name = name;
        Price = price;
    }

    // Метод для зменшення ціни продукту
    public void DecreasePrice(int dollars, int cents)
    {
        Price.DecreaseAmount(dollars, cents);
    }
}

