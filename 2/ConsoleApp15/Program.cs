using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name}, {Age} years old";
    }
}


class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine($"До обмена: a = {a}, b = {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"После обмена: a = {a}, b = {b}");

        string str1 = "Первая строка";
        string str2 = "Вторая строка";
        Console.WriteLine($"\nДо обмена: str1 = \"{str1}\", str2 = \"{str2}\"");
        Swap(ref str1, ref str2);
        Console.WriteLine($"После обмена: str1 = \"{str1}\", str2 = \"{str2}\"");

        Person person1 = new Person { Name = "Алиса", Age = 30 };
        Person person2 = new Person { Name = "Боб", Age = 25 };
        Console.WriteLine($"\nДо обмена: person1 = {person1}, person2 = {person2}");
        Swap(ref person1, ref person2);
        Console.WriteLine($"После обмена: person1 = {person1}, person2 = {person2}");
    }

    public static void Swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
}
