using System;
using System.Collections.Generic;
using System.Diagnostics;

using System;

class Program
{
    public static T Max<T>(T x, T y) where T : IComparable<T>
    {
        return x.CompareTo(y) > 0 ? x : y;
    }
    public static T Maximum<T>(T x, T y) where T : IComparable<T>
    {
        return x.CompareTo(y) > 0 ? x : y;
    }


    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        Console.WriteLine($"Максимум между {a} и {b} равен: {Maximum(a, b)}");

        string str1 = "яблоко";
        string str2 = "банан";
        Console.WriteLine($"Максимум между \"{str1}\" и \"{str2}\" равен: \"{Maximum(str1, str2)}\"");

        DateTime date1 = new DateTime(2022, 1, 1);
        DateTime date2 = new DateTime(2023, 1, 1);
        Console.WriteLine($"Максимум между {date1.ToShortDateString()} и {date2.ToShortDateString()} равен: {Maximum(date1, date2).ToShortDateString()}");
    }

}




