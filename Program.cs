using Domain;

namespace dz11._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Passport passport = new Passport("John", "Doe", "USA", "123456");
            passport.DisplayPassportInfo();
            Console.WriteLine();

            ForeignPassport foreignPassport = new ForeignPassport("John", "Doe", "USA", "123456", "654321");
            foreignPassport.AddVisa("Visa 1");
            foreignPassport.AddVisa("Visa 2");
            foreignPassport.DisplayPassportInfo();
        }
    }
}