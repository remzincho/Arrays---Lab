﻿using System;

namespace PrintNumberInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int[] arr = new int[numbers];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]+ " ");
            }
        }
    }
}
