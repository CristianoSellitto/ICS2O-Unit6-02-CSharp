// Cristiano
// ICS2O-Unit6-02-CSharp
// May 17 2022

using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        if (File.Exists("text.txt") == false)
        {
            File.WriteAllText("text.txt", "0");
        }
        string fileText = File.ReadAllText("text.txt");
        fileText = Convert.ToString(Convert.ToInt32(fileText) + 1);
        File.WriteAllText("text.txt", fileText);
        if (Convert.ToInt32(fileText) == 1)
        {
            Console.WriteLine("You’ve opened this program 1 time.");
        }
        else
        {
            Console.WriteLine("You’ve opened this program " + fileText + " times.");
        }
        Console.WriteLine("\nPress any key to quit...");
        Console.ReadKey();
        Console.WriteLine("\nFinished.");
    }
}
