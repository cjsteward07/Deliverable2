using System;

namespace deliverable2
{
    class Program
    {
        private static void Main(string[] args)
        {
            const decimal buffetPrice = 9.99M;
            const decimal smoothiePrice = 3.00M;
            const decimal mimosaPrice = 4.00M;

            int smoothieCount = 0;
            int mimosaCount = 0;

            Console.WriteLine("Aloha. Welcome to the Hawaiian buffet.");
            Console.WriteLine("Our buffet is currently on special, only $9.99 for all you can eat!");
            Console.WriteLine("If you'd like to add a drink, we're currently serving smoothies for $3.00 and mimosas for $4.00.");
            Console.WriteLine("How many people are in your party? Please keep in mind that the largest table currently available seats 8.");

            int partySize = int.Parse(Console.ReadLine());
            if (partySize <= 8)
            {
                Console.Clear();
                Console.Write($"\nAh, {partySize} guests. Excellent! Please follow me. ");
                Console.WriteLine("Alright, this table with the amazing view of Waikiki is yours.");
                Console.WriteLine("Could I get a drink order from everyone before you head to the buffet?");
                Console.WriteLine($"Just a reminder, smoothies are ${smoothiePrice} and mimosas are ${mimosaPrice}.\n");

                for (int i = 1; i <= partySize; i++)
                {
                    Console.WriteLine($"What would you like guest number {i}? Smoothie or mimosa?");
                    string? drinkOrder = Console.ReadLine();
                    if (drinkOrder == "smoothie" || drinkOrder == "Smoothie" || drinkOrder == "mimosa" || drinkOrder == "Mimosa")
                    {
                        Console.Clear();
                        Console.WriteLine($"Excellent, one {drinkOrder} coming up! \n");
                        if (drinkOrder == "smoothie" || drinkOrder == "Smoothie")
                        {
                            smoothieCount++;
                        }
                        else
                        {
                            mimosaCount++;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Sorry guest number {i}, we don't serve {drinkOrder}. We're only serving smoothies and mimosas.\n");
                    }
                }
                decimal buffetTotal = buffetPrice * partySize;
                decimal smoothieTotal = smoothiePrice * smoothieCount;
                decimal mimosaTotal = mimosaPrice * mimosaCount;
                decimal totalBill = buffetTotal + smoothieTotal + mimosaTotal;

                Console.Clear();
                Console.WriteLine($"Alright, {smoothieCount} smoothies and {mimosaCount} mimosas coming up! \n");
                Console.WriteLine("And no rush at all, but here's the bill for when you're ready. \n");

                Console.WriteLine($"{smoothieCount} smoothie x ${smoothiePrice} = ${smoothieTotal}");
                Console.WriteLine($"{mimosaCount} mimosa x ${mimosaPrice} = ${mimosaTotal}");
                Console.WriteLine($"{partySize} buffet x ${buffetPrice} = ${buffetTotal}");
                Console.WriteLine($"Total = ${totalBill}\n");
                Console.WriteLine("Thank you. See you again!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Sorry, we don't have the capacity for {partySize} right now.");
            }
        }
    }
}
