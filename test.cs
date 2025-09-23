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



        // Console.Write("Enter number: ");
        // int n = Convert.ToInt32(Console.ReadLine());
        // if (0 < n && n < 100 || 0 == n && n > 10)
        //     Console.WriteLine("True");
        // else
        //     Console.WriteLine("False");



        // 18.09.25
        // Console.Write("Task 1");
        // Console.Write("Enter  number");
        // int a = Convert.ToInt32(Console.ReadLine());
        // if (a >= 0)
        //     Console.WriteLine("Positive");
        // else
        //     Console.WriteLine("Negative");


        // Console.Write("Task 2");
        // Console.Write("Enter fisrt number");
        // int a = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter second number");
        // int b = Convert.ToInt32(Console.ReadLine());
        // if (a > b)
        //     Console.WriteLine(b);
        // if (b == a)
        //     Console.WriteLine("Equal");
        // else
        //     Console.WriteLine(a);


        // Console.Write("Task3");
        // Console.Write("Enter  number");
        // int a = Convert.ToInt32(Console.ReadLine());
        // switch (a)
        // {
        //     case 1:
        //         Console.WriteLine("Monday");
        //         break;
        //     case 2:
        //         Console.WriteLine("Tuesday");
        //         break;
        //     case 3:
        //         Console.WriteLine("Wednesday");
        //         break;
        //     case 4:
        //         Console.WriteLine("Thursday");
        //         break;
        //     case 5:
        //         Console.WriteLine("Friday");
        //         break;
        //     case 6:
        //         Console.WriteLine("Saturday");
        //         break;
        //     case 7:
        //         Console.WriteLine("Sunday");
        //         break;
        //     default:
        //         Console.WriteLine("Error");
        //         break;
        // }


        // Console.Write("Task 4");
        // Console.Write("Enter  a mark");
        // int mark = Convert.ToInt32(Console.ReadLine());
        // if (mark >= 90 && mark <= 100)
        //     Console.WriteLine("Отлично");
        // else if (mark >= 70 && mark < 90)
        //     Console.WriteLine("Хорошо");
        // else if (mark >= 50 && mark < 70)
        //     Console.WriteLine("Удовлетворительно");
        // else if (mark < 50)
        //     Console.WriteLine("Неудовлетворительно");
        // else
        //     Console.WriteLine("Error");

        // Console.Write("Task 5");
        // Console.Write("Enter fisrt number");
        // int a = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter second number");
        // int b = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter operation (+, -, *, /): ");
        // string operation = Console.ReadLine();
        // switch (operation)
        // {
        //     case "+":
        //         Console.WriteLine($"{a} + {b} = {a + b}");
        //         break;
        //     case "-":
        //         Console.WriteLine($"{a} - {b} = {a - b}");
        //         break;
        //     case "*":
        //         Console.WriteLine($"{a} * {b} = {a * b}");
        //         break;
        //     case "/":
        //         if (b != 0)
        //             Console.WriteLine($"{a} / {b} = {a / b}");
        //         else
        //             Console.WriteLine("Error: Division by zero");
        //         break;
        //     default:
        //         Console.WriteLine("Error: Invalid operation");
        //         break;
        // }


        // Console.Write("Task 6");
        // Console.Write("Enter traffic light color (red, yellow, green): ");
        // string trafficLight = Console.ReadLine();
        // switch (trafficLight)
        // {
        //     case "red":
        //         Console.WriteLine("Стой");
        //         break;
        //     case "yellow":
        //         Console.WriteLine("Приготовься");
        //         break;
        //     case "green":
        //         Console.WriteLine("Иди");
        //         break;
        //     default:
        //         Console.WriteLine("Error");
        //         break;
        // }



        // 19.09.25
        // Console.Write("Task 1");
        // for (int i = 0; i <= 11; i+=2)
        // {
        //     Console.WriteLine(i);
        // }


        // Console.Write("Task 2");
        // for (int i = 11; i >= 1; i--)
        // {
        //     Console.WriteLine(i);
        // }



        // Console.Write("Task 3");
        // int i = 1;
        // while (i <= 4)
        // {
        //     Console.WriteLine("Учусь в C#");
        //     i++;
        // }


        // Console.Write("Task 4");
        // int i = 1;
        // while (i <= 7)
        // {
        //     Console.WriteLine(i);
        //     i++;
        // }


        // Console.Write("Task 5");
        // int i = 1;
        // do
        // {
        //     Console.WriteLine(i);
        //     i++;
        // } while (i <= 3);



        // Console.Write("Task 6");
        // int i = 1;
        // do
        // {
        //     Console.WriteLine("Повторение");
        //     i++;
        // }
        // while (i <= 2);


        //  23.09.25
        // Console.WriteLine("Task 1");
        // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(number);
        // }

        // Console.WriteLine("Task 2");
        // Console.WriteLine(numbers.Max());
        // Console.WriteLine(numbers.Min());


        Console.WriteLine("Task 3");
        int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

            


    }
}