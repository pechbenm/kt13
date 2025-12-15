using System;
public class Book
{
    public string Title { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        return $"{Title}: ${Price}";
    }
}

class Program
{

    static void Main(string[] args)
    {

        string[] stringArray = { "яблоко", "банан", "манго" };
        Console.WriteLine("Строки:");
        Print(stringArray);


        int[] intArray = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Целые числа:");
        Print(Array.ConvertAll(intArray, x => x.ToString()));


        Book[] bookArray = {
            new Book { Title = "1984", Price = 29.99 },
            new Book { Title = "кровавый меридиан", Price = 35.50 },
            new Book { Title = "король в желтом", Price = 25.00 }
        };
        Console.WriteLine("Книги:");
        Print(bookArray);
        Console.ReadLine();
    }

    public static void Print<T>(T[] array) where T : class
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i].ToString());
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
