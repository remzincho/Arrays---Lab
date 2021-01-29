﻿using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] {
            "Monday", "Tuesday", "Wednesday",
                "Thursday", "Friday", "Saturday", "Sunday"
            };

            int day = int.Parse(Console.ReadLine());

            if (day > 0 && day < 8)
            {
                Console.WriteLine(days[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
