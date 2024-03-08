namespace Domain;

internal class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
}

internal class Builder : Human
{
    public string Specialization { get; set; }

    public void Build()
    {
        Console.WriteLine($"{Name} is a {Age}-year-old {Gender} {Specialization}, who can build some cool things.");
    }
}

internal class Sailor : Human
{
    public string Ship { get; set; }

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
