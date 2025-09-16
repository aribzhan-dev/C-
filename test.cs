// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Security.Cryptography;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("task 1");
        // int year = 2025;
        // Console.WriteLine($"Current year: {year}");

        // Console.WriteLine("task 2");
        // string name = "Aribzhan";
        // int age = 17;
        // Console.WriteLine($"My name's {name} and i'm {age} yo");

        // Console.WriteLine("task 3");
        // double price = 999.99;
        // int quanity = 3;
        // Console.WriteLine($"Sum : {price * quanity}");

        // Console.WriteLine("task 4");
        // char letter = 'B';
        // Console.WriteLine($"Choosen letter is {letter}");

        // Console.WriteLine("task 5");
        // bool isRain = true;
        // if (isRain == true)
        //     Console.WriteLine("Take an  umbrella");
        // else
        //     Console.WriteLine("Wheather is clever");

        // Console.WriteLine("task 6");
        // string city = "Astana";
        // int polulation = 1300000;
        // double area = 722.0;
        // Console.WriteLine($"{city} has population: {polulation} and area: {area} km");

        // Console.WriteLine("task 7");
        // int a = 7;
        // int b = 3;
        // double c = a / b; 
        // Console.WriteLine($"Sum : {a+b}");
        // Console.WriteLine($"Raznost: {a-b}");
        // Console.WriteLine($"Delenie: {c}");


        // Console.WriteLine("task 8");
        // bool isAdult = false;
        // if (isAdult == true)
        //     Console.WriteLine("Access granted");
        // else
        //     Console.WriteLine("Access denied");


        // Console.WriteLine("task 9");
        // string name = Console.ReadLine();
        // int age = Convert.ToInt32(Console.ReadLine());
        // string city = Console.ReadLine();
        // Console.WriteLine($"My name's {name} and i'm {age} and i live in {city}");

        // Console.WriteLine("task 10");
        // Console.Write("Enter a number -->");
        // int a = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter a number -->");
        // int b = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"S = {a*b} and P = {(a+b)*2}");


        // 16.09.2025 tasks
        // int a = 15;
        // int b = 4;
        // Console.WriteLine($"sum = {a + b}, raznost = {a - b}, delenie = {a / b}, umnojenie = {a * b}, ostatok = {a % b}");


        // double a = 7.5;
        // double b = 2.5;
        // Console.WriteLine($"S = {a * b}, P = {(a + b) * 2}");


        // Console.Write("Enter number: ");
        // int a = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter number: ");
        // int b = Convert.ToInt32(Console.ReadLine());
        // if (a > b)
        //     Console.WriteLine($"{a} is bigger than {b}");
        // else
        //     Console.WriteLine($"{b} is bigger than {a}");


        // Console.Write("Enter your age: ");
        // int age = Convert.ToInt32(Console.ReadLine());
        // if (age >= 18)
        //     Console.WriteLine("Access granted");
        // else
        //     Console.WriteLine("Access denied");


        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (0 < n && n < 100 || 0 == n && n > 10)
            Console.WriteLine("True");
        else
            Console.WriteLine("False");




    }
}