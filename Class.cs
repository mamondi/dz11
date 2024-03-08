namespace Domain;

using System;
using System.Collections.Generic;

public class Passport
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Nationality { get; set; }
    public string PassportNumber { get; set; }

    // Конструктор класу Passport
    public Passport(string firstName, string lastName, string nationality, string passportNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Nationality = nationality;
        PassportNumber = passportNumber;
    }

    // Метод для виведення паспортної інформації
    public virtual void DisplayPassportInfo()
    {
        Console.WriteLine($"First Name: {FirstName}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Nationality: {Nationality}");
        Console.WriteLine($"Passport Number: {PassportNumber}");
    }
}

public class ForeignPassport : Passport
{
    public List<string> VisaInformation { get; set; }
    public string ForeignPassportNumber { get; set; }

    public ForeignPassport(string firstName, string lastName, string nationality, string passportNumber, string foreignPassportNumber)
        : base(firstName, lastName, nationality, passportNumber)
    {
        VisaInformation = new List<string>();
        ForeignPassportNumber = foreignPassportNumber;
    }

    public void AddVisa(string visa)
    {
        VisaInformation.Add(visa);
    }

    public override void DisplayPassportInfo()
    {
        base.DisplayPassportInfo();
        Console.WriteLine($"Foreign Passport Number: {ForeignPassportNumber}");
        Console.WriteLine("Visa Information:");
        foreach (var visa in VisaInformation)
        {
            Console.WriteLine(visa);
        }
    }
}

