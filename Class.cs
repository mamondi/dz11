using System;

namespace Domain;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Sound { get; set; }
    public int Weight { get; set; }
    public int Speed { get; set; }

    public Animal(string name, int age, string sound, int weight, int speed)
    {
        Name = name;
        Age = age;
        Sound = sound;
        Weight = weight;
        Speed = speed;
    }

    public void Move()
    {
        Console.WriteLine($"Animal {Name} is moving with speed {Speed}");
    }

    public void MakeSound()
    {
        Console.WriteLine($"Animal {Name} is making sound {Sound}");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Sound: {Sound}, Weight: {Weight}, Speed: {Speed}");
    }

}

class Tiger : Animal
{
    public Tiger(string name, int age, string sound, int weight, int speed) : base(name, age, sound, weight, speed)
    {
    }
}

class Crocodile : Animal
{
    public Crocodile(string name, int age, string sound, int weight, int speed) : base(name, age, sound, weight, speed)
    {
    }
}

class Kangaroo : Animal
{
    public Kangaroo(string name, int age, string sound, int weight, int speed) : base(name, age, sound, weight, speed)
    {
    }
}

