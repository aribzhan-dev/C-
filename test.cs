// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections;
using System.IO.Compression;
using System.Security.Cryptography;

namespace Name
{
    enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }













    public class HelloWorld
    {

        public static string Hello()
        {
            return $"Hello, I'm learning C#!";
        }

        public static string Greet(string name)
        {
            return $"Hello, {name}!";
        }

        public static int Sum(int a, int b)
        {
            return a * b;
        }

        public static int Increment(ref int a)
        {
            a++;
            return a;
        }


        public static int Devide(int c, int d, out int result)
        {
            result = c / d;
            return result;
        }




        // 30.09.25 Practice

        public static string GreetGroup(string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine($"Hello, {name}!");
            }
            return "";
        }


        public static int Avarage(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }


        public static int FindMaxMin(int[] numbers2, out int min)
        {
            int max = numbers2[0];
            min = numbers2[0];
            foreach (int number in numbers2)
            {
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }
            return max;
        }


        public static string CheckPassword(string password, string correctPassword)
        {
            if (password == correctPassword)
            {
                return "Access granted";
            }
            else
            {
                return "Access denied";
            }
        }


        public static int CountVovels(string str)
        {
            int counter = 0;
            for (int s = 0; s <= (str.Length) - 1; s++)
            {
                if (str.ToLower()[s] == 'a' || str.ToLower()[s] == 'e' || str.ToLower()[s] == 'i' || str.ToLower()[s] == 'o' || str.ToLower()[s] == 'u' || str.ToLower()[s] == 'y')
                {
                    counter++;
                }
            }
            return counter;
        }


        public static int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }


        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b, out double result)
        {
            if (b != 0)
            {
                result = (double)a / b;
                return result;
            }
            else
            {
                result = 0;
                Console.WriteLine("Error: Division by zero");
                return result;
            }
        }



        public static void IncreaseArray(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] + 1;
            }
            Console.WriteLine($"New array: [{string.Join(", ", arr)}]");
        }


        public static void Analyze(string text, out int letters, out int digits, out int spaces)
        {
            letters = 0;
            digits = 0;
            spaces = 0;
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                    letters++;
                else if (char.IsDigit(c))
                    digits++;
                else if (char.IsWhiteSpace(c))
                    spaces++;
            }
            Console.WriteLine($"Letters: {letters}, Digits: {digits}, Spaces: {spaces}");
        }


        public static void PrintTable(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
        }


        public static string Vovel(string user_text)
        {
            int counter = 0;
            foreach (char c in user_text.ToLower())
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'u' || c == 'y' || c == 'o')
                {
                    counter++;
                }
            }
            return $"in {user_text} we have {counter} vovels";
        }












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



            // 26.09.25
            // Console.WriteLine("Task 1");
            // static string Hello(string name)
            // {
            //     return $"Hello, {name}!";
            // }
            // Console.Write("Enter your name: ");
            // string name = Console.ReadLine();
            // Console.WriteLine(Hello(name));

            // Console.WriteLine("Task 1");
            // Console.WriteLine(Hello());


            // Console.WriteLine("Task 2");
            // Console.WriteLine("Enter yout name -- >");
            // string name = Console.ReadLine();
            // Console.WriteLine(Greet(name));


            // Console.WriteLine("Task 3");
            // Console.WriteLine("Enter a number -->");
            // int a = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter a number -->");
            // int b = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"Sum = {Sum(a, b)}");


            // Console.WriteLine("Task 4");
            // Console.WriteLine("Enter a number to increment -->");
            // int n = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"Incremented value = {Increment(ref n)}");


            // Console.WriteLine("Task 5");
            // Console.WriteLine("Enter a number -->");
            // int c = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter a number -->");
            // int d = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"Devide = {Devide(c, d, out int result)}");





            // 30.09.25 Practice
            // Console.WriteLine("Task 1");
            // string[] names = { "Aribzhan", "Azamat", "Sanzhar" };
            // GreetGroup(names);

            // Console.WriteLine("Task 2");
            // int[] numbers = { 10, 20, 30, 40, 50 };
            // Console.WriteLine($"Avarage = {Avarage(numbers)}");

            // Console.WriteLine("Task 3");
            // int[] numbers2 = { 5, 2, 9, 1, 7 };
            // Console.WriteLine($"Max = {FindMaxMin(numbers2, out int min)} and Min = {min}");


            // Console.WriteLine("Task 4");
            // Console.Write("Enter a correck password -->");
            // string correctPassword = Console.ReadLine();
            // Console.Write("Enter a password -->");
            // string password = Console.ReadLine();
            // Console.WriteLine(CheckPassword(password, correctPassword));


            // Console.WriteLine("task 5");
            // Console.Write("Enter a string -->");
            // string str = Console.ReadLine();
            // Console.WriteLine($"In this string we have {CountVovels(str)} vovels");


            // Console.WriteLine("task 6");
            // Console.Write("Enter a number -->");
            // int n = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"Factorial of {n} is {Factorial(n)}");

            // Console.WriteLine("task 7");
            // Console.Write("Enter a number -->");
            // int a = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Enter a number -->");
            // int b = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Enter an operation (+, -, *, /) -->");
            // string operation = Console.ReadLine();
            // switch (operation)
            // {
            //     case "+":
            //         Console.WriteLine($"Result: {Add(a, b)}");
            //         break;
            //     case "-":
            //         Console.WriteLine($"Result: {Subtract(a, b)}");
            //         break;
            //     case "*":
            //         Console.WriteLine($"Result: {Multiply(a, b)}");
            //         break;
            //     case "/":
            //         Console.WriteLine($"Result: {Divide(a, b, out double result)}");
            //         break;
            //     default:
            //         Console.WriteLine("Error: Invalid operation");
            //         break;
            // }
            // ;


            // Console.WriteLine("task 8");
            // int[] arr = { 1, 2, 3, 4, 5 };
            // IncreaseArray(ref arr);


            // Console.WriteLine("task 9");
            // Console.Write("Enter a string -->");
            // string text = Console.ReadLine();
            // Analyze(text, out int letters, out int digits, out int spaces);


            // Console.WriteLine("task 10");
            // Console.Write("Enter a number -->");
            // int number = Convert.ToInt32(Console.ReadLine());
            // PrintTable(number);


            // Console.Write("Practice");
            // Console.WriteLine("enter a text -- >>");
            // string user_text = Console.ReadLine();
            // Console.WriteLine(Vovel(user_text));



            // Practise 8, 9 work 07.10.25

            // Console.WriteLine("Task 1");
            // Console.Write("Enter a text -->");
            // string user_text = Console.ReadLine();
            // File.WriteAllText("user_message.txt", user_text);
            // Console.WriteLine("Text saved to user_message.txt");
            // Console.WriteLine(File.ReadAllText("user_message.txt"));



            // Console.WriteLine("Task 2");
            // Console.Write("Enter a how manu products you want to buy -->");
            // int n = Convert.ToInt32(Console.ReadLine());
            // for (int i = 1; i <= n; i++)
            // {
            //     Console.Write($"Enter a product name -->");
            //     string product_name = Console.ReadLine();
            //     File.AppendAllText("products.txt", $"{i}) {product_name + '\n'}");
            // }
            // string[] product = File.ReadAllLines("products.txt");
            // foreach (string p in product)
            // {
            //     Console.WriteLine(p);
            // }  


            // Console.WriteLine("Task 3");
            // Console.WriteLine("1. New notes");
            // Console.WriteLine("2. Show all notes");
            // Console.WriteLine("3. Exit");
            // while (true)
            // {
            //     Console.Write("Chose one of the options:");
            //     int question = Convert.ToInt32(Console.ReadLine());
            //     switch (question)
            //     {
            //         case 1:
            //             Console.Write("Enter a note -->");
            //             string note = Console.ReadLine();
            //             File.AppendAllText("notes.txt", $"{note + '\n'}");
            //             break;
            //         case 2:
            //             string[] notes = File.ReadAllLines("notes.txt");
            //             foreach (string n in notes)
            //             {
            //                 Console.WriteLine(n);
            //             }
            //             break;
            //         case 3:
            //             Console.WriteLine("Exiting...");
            //             break;
            //         default:
            //             Console.WriteLine("Error");
            //             break;
            //     }
            //     if (question == 3)
            //         break;

            // }


            // Console.WriteLine("Task 4");
            // string[] line = File.ReadAllLines("products.txt");
            // int len = line.Length;
            // if (len == 0)
            // {
            //     Console.WriteLine("File is empty");
            // }
            // else
            // {
            //     Console.WriteLine(len);
            // }




            // Console.WriteLine("task 5");
            // Console.Write("enter wich file you want to copu -->");
            // string file_name = Console.ReadLine();
            // bool file = File.Exists($"{file_name}");
            // if (file == true)
            // {
            //     File.Copy($"{file_name}", "new_user.txt", true);
            //     Console.WriteLine("Succesfulli copied");
            // }
            // else
            // {
            //     Console.WriteLine("nothing to copy");
            // }
            // Console.WriteLine(File.ReadAllText("new_user.txt"));



            // Console.WriteLine("Task 6");
            // Console.Write("enter wich file you want to copu -->");
            // string file_name = Console.ReadLine();
            // try
            // {
            //     Console.WriteLine(File.ReadAllText(file_name));
            // }
            // catch (FileNotFoundException ex)
            // {
            //     Console.WriteLine($"{file_name} :   {ex.Message}");
            // }



            // Console.WriteLine("Task 7");
            // Console.Write("Enter a number -->");
            // string n = Console.ReadLine();
            // Console.Write("Enter a number -->");
            // string m = Console.ReadLine();
            // try
            // {
            //     int parsed_n = int.Parse(n);
            //     int parsed_m = int.Parse(m);
            //     Console.WriteLine($"{parsed_n} / {parsed_m} = {parsed_n / parsed_m}");
            //     Console.WriteLine($"{parsed_m} / {parsed_n} = {parsed_m / parsed_n}");
            // }
            // catch (DivideByZeroException ex)
            // {
            //     Console.WriteLine($"Error: Division by zero is not allowed. {ex.Message}");
            // }
            // catch (FormatException ex)
            // {
            //     Console.WriteLine($"Error: Invalid input format. {ex.Message}");
            // }


            // Console.WriteLine("Task 8");
            // Console.Write("Enter a number -->");
            // string n = Console.ReadLine();
            // Console.Write("Enter a number -->");
            // string m = Console.ReadLine();
            // Console.Write("Enter an operation (+, -, *, /) -->");
            // char operation = Console.ReadLine()[0];
            // try
            // {
            //     int parsed_n = int.Parse(n);
            //     int parsed_m = int.Parse(m);
            //     switch (operation)
            //     {
            //         case '+':
            //             Console.WriteLine($"{parsed_n} + {parsed_m} = {parsed_n + parsed_m}");
            //             break;
            //         case '-':
            //             Console.WriteLine($"{parsed_n} - {parsed_m} = {parsed_n - parsed_m}");
            //             break;
            //         case '*':
            //             Console.WriteLine($"{parsed_n} * {parsed_m} = {parsed_n * parsed_m}");
            //             break;
            //         case '/':
            //             Console.WriteLine($"{parsed_n} / {parsed_m} = {parsed_n / parsed_m}");
            //             Console.WriteLine($"{parsed_m} / {parsed_n} = {parsed_m / parsed_n}");
            //             break;
            //         default:
            //             Console.WriteLine("Error: Invalid operation.");
            //             break;
            //     }

            // }
            // catch (DivideByZeroException ex)
            // {
            //     Console.WriteLine($"Error: Division by zero is not allowed. {ex.Message}");
            // }
            // catch (FormatException ex)
            // {
            //     Console.WriteLine($"Error: Invalid input format. {ex.Message}");
            // }


            // Console.WriteLine("Task 9");
            // Console.Write("Enter a file name -->");
            // string file_name = Console.ReadLine();
            // try
            // {
            //     if (!File.Exists(file_name))
            //     {
            //         File.WriteAllText(file_name, "");
            //         Console.WriteLine($"File '{file_name}' created.");
            //     }
            //     string content = File.ReadAllText(file_name);
            //     Console.WriteLine(content);
            // }
            // catch (FileNotFoundException ex)
            // {
            //     Console.WriteLine($"Error: The file '{file_name}' was not found. {ex.Message}");
            // }
            // catch (UnauthorizedAccessException ex)
            // {
            //     Console.WriteLine($"Error: You do not have permission to access the file '{file_name}'. {ex.Message}");
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            // }


            // Console.WriteLine("Task 10");
            // try
            // {
            //     if (!File.Exists("log.txt"))
            //     {
            //         File.WriteAllText("log.txt", $"[{DateTime.Now}] Log file created.\n");
            //         Console.WriteLine("File 'log.txt' created.");
            //     }
            //     else
            //     {
            //         File.AppendAllText("log.txt", $"[{DateTime.Now}] Log file accessed.\n");
            //         Console.WriteLine("Log entry added to 'log.txt'.");
            //     }
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            // }


            // Console.WriteLine(File.ReadAllText("log.txt"));





            // Practise task
            // Console.Write("Enter a file name -->");
            // string file_name = Console.ReadLine();
            // if (File.Exists($"{file_name}"))
            // {
            //     Console.WriteLine($"{file_name} this file already exist");
            // }
            // else
            // {
            //     File.WriteAllText($"{file_name}", "Welcome");
            //     Console.WriteLine($"{file_name} successfulli created");
            // }




            // Practise yask 10.10.25

            // Console.WriteLine("Task 1");
            // List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // foreach (int n in numbers)
            // {
            //     Console.WriteLine(n);
            // }



            // Console.WriteLine("Task 2");
            // List<string> fruets = new List<string> { "Apple", "Banana", "Cherry" };
            // Console.Write("Enter a fruit to add:");
            // string newFruet = Console.ReadLine();
            // if (!fruets.Contains(newFruet))
            // {
            //     fruets.Add(newFruet);
            //     Console.WriteLine("Updated list of fruits:");
            // }
            // else
            // {
            //     Console.WriteLine("This fruit is already in the list.");
            // }
            // foreach (string fruit in fruets)
            // {
            //     Console.WriteLine(fruit);
            // }
            // Console.Write("Chose froet to remove:");
            // string remove_fruet = Console.ReadLine();
            // if (!fruets.Contains(remove_fruet))
            // {
            //     Console.WriteLine("This fruit is not in the list.");
            // }
            // else
            // {
            //     fruets.Remove(remove_fruet);
            //     Console.WriteLine("Updated list of fruits:");
            // }
            // foreach (string f in fruets)
            // {
            //     Console.WriteLine(f);
            // }


            // Console.WriteLine("Task 3");
            // List<int> numbers = new List<int> { 5, 3, 8, 1, 2 };
            // Console.Write("Enter a number to search:");
            // int searchNumber = Convert.ToInt32(Console.ReadLine());
            // if (numbers.Contains(searchNumber))
            // {
            //     Console.WriteLine($"Number {searchNumber} found in the list.");
            // }
            // else
            // {
            //     Console.WriteLine($"Number {searchNumber} not found in the list.");
            // }




            // Console.WriteLine("Task 4");
            // Day today = Day.Wednesday;
            // Console.WriteLine($"Today is: {today}");



            // Console.WriteLine("Task 5");
            // Day today = Day.Monday;
            // switch (today)
            // {
            //     case Day.Monday:
            //         Console.WriteLine("It's Monday, the start of the week!");
            //         break;
            //     case Day.Tuesday:
            //         Console.WriteLine("It's Tuesday, keep going!");
            //         break;
            //     case Day.Wednesday:
            //         Console.WriteLine("It's Wednesday, we're halfway through!");
            //         break;
            //     case Day.Thursday:
            //         Console.WriteLine("It's Thursday, the weekend is near!");
            //         break;
            //     case Day.Friday:
            //         Console.WriteLine("It's Friday, the weekend is almost here!");
            //         break;
            //     case Day.Saturday:
            //         Console.WriteLine("It's Saturday, enjoy your day off!");
            //         break;
            //     case Day.Sunday:
            //         Console.WriteLine("It's Sunday, get ready for the week ahead!");
            //         break;
            //     default:
            //         Console.WriteLine("Error: Invalid day.");
            //         break;
            // }







































        }
    }
}

public struct Students
{
    public string Name;
    public int Age;
    public int Grade;

    public Students(string Name, int Age, int Grade)
    {
        this.Name = Name;
        this.Age = Age;
        this.Grade = Grade;
    }

    public void Display()
    {
        Students student = new Students("Aribzhan", 17, 11);
        Console.WriteLine($"Student name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
    }
}




