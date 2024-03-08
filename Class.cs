namespace Domain;

//Класс паспорт громадянина заданої країни - Україна

    public void Sail()
    {
        Console.WriteLine($"{Name} is a {Age}-year-old {Gender} sailor, who sails the {Ship}.");
    }
}

internal class Pilot : Human
{
    public string Plane { get; set; }

    public void Fly()
    {
        Console.WriteLine($"{Name} is a {Age}-year-old {Gender} pilot, who flies {Plane}.");
    }
}