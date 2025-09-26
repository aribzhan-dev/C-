// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.IO.Compression;
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


        // Console.WriteLine("Task 3");
        // int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(number);
        // }


        // Console.WriteLine("Task 4");
        // int[] numbers = { 1, 2, 3, 4, 5 };
        // Console.WriteLine($"the length of list -- > {numbers.Length}");

        // Console.WriteLine("Task 5");
        // Console.WriteLine($"the first elemetn -- > {numbers[0]} and the last element -- > {numbers[numbers.Length - 1]}");



        // Home work 23.09.25
        // Console.WriteLine("Task 1");
        // int[] numbers = { 1, 2, 3, 4, 5 };
        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(number);
        // }


        // Console.WriteLine("Task 2");
        // int[] numbers = { 1, 2, 3, 4 };
        // Console.WriteLine(numbers.Sum());


        // Console.WriteLine("Task 3");
        // Console.Write("Enter a string: ");
        // string str = Console.ReadLine();
        // Console.WriteLine($"Length of the string: {str.Length}");
        // Console.WriteLine(str.ToUpper());
        // int counter = 0;
        // for (int s = 0; s <= (str.Length)-1; s++)
        // {
        //     if (str.ToLower()[s] == 'a' || str.ToLower()[s] == 'e' || str.ToLower()[s] == 'i' || str.ToLower()[s] == 'o' || str.ToLower()[s] == 'u' || str.ToLower()[s] == 'y')
        //     {
        //         counter++;
        //     }
        // }
        // Console.WriteLine($"Number of vowels: {counter}");





        // 25.09.25 Practice
        // Console.WriteLine("Task 1");
        // string[] attendance = { "Present", "Absent", "Present", "Present", "Absent", "Present" };
        // int present_counter = 0;
        // int absent_counter = 0;
        // foreach (string status in attendance)
        // {
        //     if (status == "Present")
        //         present_counter++;
        //     else
        //         absent_counter++;
        // }

        // Console.WriteLine($"{present_counter} is present and {absent_counter} student is apsent");
        // if (absent_counter > 3)
        // {
        //     Console.WriteLine("SO manu absents");
        // }


        // Console.WriteLine("Task 2");
        // string[] menu = { "Plov", "Lagman", "Manty", "Log out" };
        // Console.WriteLine("Menu:");
        // for (int i = 0; i <= (menu.Length) - 1; i++)
        // {
        //     Console.WriteLine($"{i + 1}. {menu[i]}");

        // }
        // do
        // {
        //     Console.WriteLine("chose a number");
        //     int choise = Convert.ToInt32(Console.ReadLine());
        //     switch (choise)
        //     {
        //         case 1:
        //             Console.WriteLine("You chose Plov");
        //             break;
        //         case 2:
        //             Console.WriteLine("You chose Lagman");
        //             break;
        //         case 3:
        //             Console.WriteLine("You chose Manty");
        //             break;
        //         case 4:
        //             Console.WriteLine("Logging out...");
        //             break;
        //         default:
        //             Console.WriteLine("Error");
        //             break;
        //     }
        //     if (choise == 4)
        //         break;
        // }
        // while (true);


        // Console.WriteLine("Task 3");
        // do
        // {
        //     Console.Write("enter a passwrod --->");
        //     string password = Console.ReadLine();
        //     if (password == "1234")
        //     {
        //         Console.WriteLine("Access granted");
        //         break;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Access denied");
        //     }
        // }
        // while (true);


        // Console.WriteLine("Task 4");
        // int[] marks = { 85, 92, 78, 90, 88 };
        // int sum = 0;
        // foreach (int mark in marks)
        // {
        //     sum += mark;
        // }
        // double average = (double)sum / marks.Length;
        // if (average >= 90)
        //     Console.WriteLine("Perfect");
        // else if (average >= 70)
        //     Console.WriteLine("Good");
        // else if (average >= 50)
        //     Console.WriteLine("Not bad");
        // else
        //     Console.WriteLine("You have a some problems");


        // Random random = new Random();

        // Console.WriteLine("Task 5");
        // int number = random.Next(101);
        // int counter = 0;
        // while (true)
        // {
        //     Console.Write("Guess the number (0-100): ");
        //     int guess = Convert.ToInt32(Console.ReadLine());
        //     if (guess < number)
        //     {
        //         counter++;
        //         Console.WriteLine("Too low");
        //     }
        //     else if (guess > number)
        //     {
        //         counter++;
        //         Console.WriteLine("Too high");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Congratulations! You guessed the number.");
        //         break;
        //     }

        // }
        // Console.WriteLine($"You tried {counter} times");



        // Console.WriteLine("Task 6");
        // Console.Write("Enter a string: ");
        // string str = Console.ReadLine();
        // int n = 0;
        // foreach (char c in str)
        // {
        //     if (c == 'a' || c == 'A')
        //     {
        //         n++;
        //     }
        // }
        // if (n > 0)
        //     Console.WriteLine($"The letter 'a' appears {n} times in the string.");
        // else
        //     Console.WriteLine("The letter 'a' does not appear in the string.");


        // Console.WriteLine("Task 7");
        // Console.WriteLine("Menu:");
        // Console.WriteLine("1. Show balance");
        // Console.WriteLine("2. Popolnit balance");
        // Console.WriteLine("3. Withdraw money");
        // Console.WriteLine("4. Exit");
        // int balance = 1000;
        // do
        // {
        //     Console.Write("Choose an option (1-4): ");
        //     int option = Convert.ToInt32(Console.ReadLine());
        //     switch (option)
        //     {
        //         case 1:
        //             Console.WriteLine($"Your balance is: {balance}");
        //             break;
        //         case 2:
        //             Console.Write("Enter amount to deposit: ");
        //             int deposit = Convert.ToInt32(Console.ReadLine());
        //             if (deposit > 0)
        //             {
        //                 balance += deposit;
        //                 Console.WriteLine($"Deposited: {deposit}. New balance: {balance}");
        //             }
        //             else
        //             {
        //                 Console.WriteLine("Error: Deposit amount must be positive.");
        //             }
        //             break;
        //         case 3:
        //             Console.Write("Enter amount to withdraw: ");
        //             int withdraw = Convert.ToInt32(Console.ReadLine());
        //             if (withdraw > 0 && withdraw <= balance)
        //             {
        //                 balance -= withdraw;
        //                 Console.WriteLine($"Withdrew: {withdraw}. New balance: {balance}");
        //             }
        //             else if (withdraw > balance)
        //             {
        //                 Console.WriteLine("Error: Insufficient funds.");
        //             }
        //             else
        //             {
        //                 Console.WriteLine("Error: Withdrawal amount must be positive.");
        //             }
        //             break;
        //         case 4:
        //             Console.WriteLine("Exiting...");
        //             break;
        //         default:
        //             Console.WriteLine("Error: Invalid option.");
        //             break;
        //     }
        //     if (option == 4)
        //         break;

        // }
        // while (true);


        // Console.WriteLine("Task 8");
        // int even_counter = 0;
        // int odd_counter = 0;
        // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     if (numbers[i] % 2 == 0)
        //     {
        //         even_counter++;
        //     }
        //     else
        //     {
        //         odd_counter++;
        //     }
        // }
        // Console.WriteLine($"Even numbers: {even_counter}, Odd numbers: {odd_counter}");



        // Console.WriteLine("Task 9");
        // for (int i = 1; i <= 9; i++)
        // {
        //     for (int j = 1; j <= 9; j++)
        //     {
        //         Console.Write($"{i} * {j} = {i * j}\t");
        //     }
        //     Console.WriteLine();
        // }




        // Console.WriteLine("Task 10");
        // Console.WriteLine("Enter a string: ");
        // string str = Console.ReadLine();
        // string[] values = str.Split(' ');

        // Console.WriteLine($" in this sentence we have --> {values.Length} words");


    }
}