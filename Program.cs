using Domain;

namespace dz11._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money(10, 50);
            money.DisplayAmount();
            money.DecreaseAmount(5, 75);
            money.DisplayAmount();

            Product product = new Product("Bread", new Money(5, 25));
            product.DecreasePrice(2, 50);
            product.Price.DisplayAmount();
        }
    }
}
