using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeopleCount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string Weekday = Console.ReadLine();
            double totalPrice = 0;

            if (type == "Students")
            {
                if (Weekday == "Friday")
                {
                    totalPrice = PeopleCount * 8.45;
                }
                else if (Weekday == "Saturday")
                {
                    totalPrice = PeopleCount * 9.80;
                }
                else if (Weekday == "Sunday")
                {
                    totalPrice = PeopleCount * 10.46;
                }
                    if (PeopleCount >= 30)
                    {
                    totalPrice -= totalPrice * 0.15;
                    }
            }

            else if (type == "Business")
            {
                if (Weekday == "Friday")
                {
                    totalPrice = PeopleCount * 10.90;
                }
                else if (Weekday == "Saturday")
                {
                    totalPrice = PeopleCount * 15.60;
                }
                else if (Weekday == "Sunday")
                {
                    totalPrice = PeopleCount * 16;
                }
                    if (PeopleCount >= 100)
                    {
                    totalPrice -= totalPrice / PeopleCount * 10;
                    }
            }

            else if (type == "Regular")
            {
                if (Weekday == "Friday")
                {
                    totalPrice = PeopleCount * 15;
                }
                else if (Weekday == "Saturday")
                {
                    totalPrice = PeopleCount * 20;
                }
                else if (Weekday == "Sunday")
                {
                    totalPrice = PeopleCount * 22.50;
                }
                    if (PeopleCount >= 10 && PeopleCount <= 20)
                    {
                        totalPrice -= totalPrice * 0.05;
                    }


            }

            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
