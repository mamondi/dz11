using System;

public class MusicalInstrument
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string History { get; set; }

    public MusicalInstrument(string name, string description, string history)
    {
        Name = name;
        Description = description;
        History = history;
    }

    public virtual void Sound()
    {
        Console.WriteLine($"Playing {Name}");
    }

    public void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Description: {Description}");
    }

    public void HistoryInfo()
    {
        Console.WriteLine($"History: {History}");
    }
}

public class Violin : MusicalInstrument
{
    public Violin(string name, string description, string history) : base(name, description, history)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"The sound of {Name}: screeeech");
    }
}

public class Trombone : MusicalInstrument
{
    public Trombone(string name, string description, string history) : base(name, description, history)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"The sound of {Name}: bwaap bwaap bwaap");
    }
}

public class Ukulele : MusicalInstrument
{
    public Ukulele(string name, string description, string history) : base(name, description, history)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"The sound of {Name}: pling pling pling");
    }
}


public class Cello : MusicalInstrument
{
    public Cello(string name, string description, string history) : base(name, description, history)
    {
    }


    public override void Sound()
    {
        Console.WriteLine($"The sound of {Name}: mellow mellow mellow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Violin violin = new Violin("Violin", "String instrument with four strings and a bow", "First used in 16th century Italy");
        Trombone trombone = new Trombone("Trombone", "Brass instrument with a slide", "Developed in the Middle Ages");
        Ukulele ukulele = new Ukulele("Ukulele", "Small guitar-like instrument from Hawaii", "Introduced to Hawaii by Portuguese immigrants in the late 19th century");
        Cello cello = new Cello("Cello", "String instrument with four strings played with a bow", "Originated in Italy during the late 17th century");

        violin.Sound();
        trombone.Sound();
        ukulele.Sound();
        cello.Sound();

        Console.WriteLine("\nInstrument Info:");
        violin.Show();
        violin.Desc();
        violin.HistoryInfo();

        trombone.Show();
        trombone.Desc();
        trombone.HistoryInfo();

        ukulele.Show();
        ukulele.Desc();
        ukulele.HistoryInfo();

        cello.Show();
        cello.Desc();
        cello.HistoryInfo();
    }
}
