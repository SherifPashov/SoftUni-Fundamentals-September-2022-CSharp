﻿using System;

namespace _07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int money = 0;

            switch (day)
            {
                case "Weekday":
                    if (0 <= age && age <= 18)
                    {
                        money = 12;
                    }
                    else if (18 < age && age <= 64)
                    {
                        money = 18;
                    }
                    else if (64 < age && age <= 122)
                    {
                        money = 12;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Weekend":
                    if (0 <= age && age <= 18)
                    {
                        money = 15;
                    }
                    else if (18 < age && age <= 64)
                    {
                        money = 20;
                    }
                    else if (64 < age && age <= 122)
                    {
                        money = 15;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break ;
                case "Holiday":
                    if (0 <= age && age <= 18)
                    {
                        money = 5;
                    }
                    else if (18 < age && age <= 64)
                    {
                        money = 12;
                    }
                    else if (64 < age && age <= 122)
                    {
                        money = 10;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;

            }
            if (money > 0 )
            {
                Console.WriteLine($"{money}$");
            }
        }
    }
}
