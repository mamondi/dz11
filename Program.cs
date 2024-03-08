using Domain;

namespace dz11._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger("Tiger", 5, "Roar", 200, 60);
            Crocodile crocodile = new Crocodile("Crocodile", 10, "Grrr", 500, 40);
            Kangaroo kangaroo = new Kangaroo("Kangaroo", 3, "Hop", 100, 80);

            tiger.ShowInfo();
            tiger.Move();
            tiger.MakeSound();

            Console.WriteLine(" ");

            crocodile.ShowInfo();
            crocodile.Move();
            crocodile.MakeSound();

            Console.WriteLine(" ");

            kangaroo.ShowInfo();
            kangaroo.Move();
            kangaroo.MakeSound();
        }
    }
}