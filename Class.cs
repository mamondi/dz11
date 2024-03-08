using System;

namespace Domain;

public abstract class Worker
{
    public abstract void Print();
}

public class President : Worker
{
    public override void Print()
    {
        Console.WriteLine("President: The leader of the company.");
    }
}

public class Security : Worker
{
    public override void Print()
    {
        Console.WriteLine("Security: Responsible for maintaining security measures.");
    }
}

public class Manager : Worker
{
    public override void Print()
    {
        Console.WriteLine("Manager: Oversees a specific department or team.");
    }
}

public class Engineer : Worker
{
    public override void Print()
    {
        Console.WriteLine("Engineer: Designs and builds products or systems.");
    }
}

