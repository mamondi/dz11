using Domain;

namespace dz11._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker president = new President();
            Worker security = new Security();
            Worker manager = new Manager();
            Worker engineer = new Engineer();


            Console.WriteLine("Information about workers:");
            president.Print();
            security.Print();
            manager.Print();
            engineer.Print();
        }
    }
}