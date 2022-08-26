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

            Console.WriteLine("Aloha. Welcome to the hawaiian buffet.");
            Console.WriteLine("Our buffet is currently on special, only $9.99 for all you can eat!");
            Console.WriteLine("If you'd like to add a drink, we're currently serving smoothies for $3.00 and mimosas for $4.00.");
            Console.WriteLine("How many people are in your party? Please keep in mind that the largest table currently available seats 8.");

            int partySize = int.Parse(Console.ReadLine());
            if (partySize <= 8)
            {
                Console.Clear();
                Console.WriteLine($"\nAh, {partySize} guests. Excellent! Please follow me. \n");
                Console.WriteLine("Alright, this table with the amazing view of Waikiki is yours. \n");
                Console.WriteLine("Could I get a drink order from everyone before you head to the buffet?");
                Console.WriteLine($"Just a reminder, smoothies are ${smoothiePrice} and mimosas are ${mimosaPrice}.\n");

                for (int i = 1; i <= partySize; i++) {
                    Console.WriteLine($"Alright, what would you like guest number {i}? Smoothie or mimosa?");
                    string? drinkOrder = Console.ReadLine();
                    if (drinkOrder == "smoothie" || drinkOrder == "mimosa")
                    {
                        Console.Clear();
                        Console.WriteLine($"Excellent, one {drinkOrder} coming up! \n");
                        if (drinkOrder == "smoothie")
                        {
                            smoothieCount ++;
                        }
                        else
                        {
                            mimosaCount ++;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Sorry guest number {i}, we don't serve {drinkOrder}. We're only serving smoothies and mimosas.");
                    }
                }
                decimal buffetTotal = buffetPrice * partySize;
                decimal smoothieTotal = smoothiePrice * smoothieCount;
                decimal mimosaTotal = mimosaPrice * mimosaCount;
                decimal totalBill = buffetTotal + smoothieTotal + mimosaTotal;

                Console.WriteLine($"Alright, {smoothieCount} smoothies and {mimosaCount} mimosas coming up! \n");
                Console.WriteLine("Here you go, and no rush at all, but here's the bill for when you're ready. \n");

                Console.WriteLine($"{smoothieCount} smoothie x ${smoothiePrice} = ${smoothieTotal}");
                Console.WriteLine($"{mimosaCount} mimosa x ${mimosaPrice} = ${mimosaTotal}");
                Console.WriteLine($"{partySize} buffet x ${buffetPrice} = ${buffetTotal}");
                Console.WriteLine($"Total = ${totalBill}\n");
                Console.WriteLine(" Thank you. See you again!");
            }
            else
            {
                Console.WriteLine($"Sorry, we don't have the capacity for {partySize} right now.");
            }
        }
    }
}
