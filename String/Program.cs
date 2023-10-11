using System;
namespace Strings;

class Program
{
    public static void Main(string[] args)
    {   
        System.Console.WriteLine("Enter Any Input :");
        string value = Console.ReadLine();
        System.Console.WriteLine("Enter Input to Match :");
        string toSearch = Console.ReadLine();
        string[] result = value.Split(toSearch);
        System.Console.WriteLine(result.Length-1);
        
    }
}