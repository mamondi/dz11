using System;
using Domain;

namespace dz11._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder bob = new Builder
            {
                Name = "Bob",
                Age = 35,
                Gender = "male",
                Specialization = "carpenter"
            };

            Sailor alice = new Sailor
            {
                Name = "Alice",
                Age = 28,
                Gender = "female",
                Ship = "The Black Pearl"
            };

            Pilot john = new Pilot
            {
                Name = "John",
                Age = 45,
                Gender = "male",
                Plane = "Boeing 747"
            };

            bob.Build();
            alice.Sail();
            john.Fly();
        }
    }
}
