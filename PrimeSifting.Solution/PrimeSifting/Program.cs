using System;
using PrimeSifting.Models;
using System.Collections.Generic;

namespace PrimeSifting
{
    public class Program
    {
      public static void Main()
      {
        Console.WriteLine("Enter a number to see the Primes up to that number: ");
        int num  = int.Parse(Console.ReadLine());
        List<int> result = Prime.FindPrimes(num);
        foreach (int item in result)
        {
            Console.WriteLine(item);
        }
      }
    }
}