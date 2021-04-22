using System;

namespace RealEstateSelling
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House(123, 70100);
            house.Attach(new PotentialBuyer("John Silez", 60000));
            house.Attach(new PotentialBuyer("Marco Torrico", 62000));
            house.Attach(new PotentialBuyer("Raul Mendoza", 64444));

            house.Price = 75000;
            house.Price = 63000;
            house.Price = 61000;
            house.Price = 60000;

            Console.ReadKey();
        }
    }
}
