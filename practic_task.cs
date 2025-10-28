// using System;
// using System.Collections.Generic;

// class Animal
// {
//     public virtual void Speak()
//     {
//         Console.WriteLine("Животное издает звук");
//     }
// }

// class Cow : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine("Мууу");
//     }
// }

// class Sheep : Animal
// {
//     public override void Speak()
//     {
//         Console.WriteLine("Беее");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         List<Animal> animals = new List<Animal> { new Cow(), new Sheep() };

//         foreach (var a in animals)
//             a.Speak();
//     }
// }




// using System;
// using System.Collections.Generic;

// abstract class Shape
// {
//     public abstract double GetArea();
//     public abstract double GetPerimeter();
// }

// class Rectangle : Shape
// {
//     double width, height;
//     public Rectangle(double w, double h)
//     {
//         width = w;
//         height = h;
//     }
//     public override double GetArea() => width * height;
//     public override double GetPerimeter() => 2 * (width + height);
// }

// class Circle : Shape
// {
//     double radius;
//     public Circle(double r) { radius = r; }
//     public override double GetArea() => Math.PI * radius * radius;
//     public override double GetPerimeter() => 2 * Math.PI * radius;
// }

// class Program
// {
//     static void Main()
//     {
//         List<Shape> shapes = new List<Shape>
//         {
//             new Rectangle(5, 3),
//             new Circle(2)
//         };

//         foreach (var s in shapes)
//             Console.WriteLine($"Площадь = {s.GetArea()}, Периметр = {s.GetPerimeter()}");
//     }
// }using System;
// using System.Collections.Generic;

// abstract class Shape
// {
//     public abstract double GetArea();
//     public abstract double GetPerimeter();
// }

// class Rectangle : Shape
// {
//     double width, height;
//     public Rectangle(double w, double h)
//     {
//         width = w;
//         height = h;
//     }
//     public override double GetArea() => width * height;
//     public override double GetPerimeter() => 2 * (width + height);
// }

// class Circle : Shape
// {
//     double radius;
//     public Circle(double r) { radius = r; }
//     public override double GetArea() => Math.PI * radius * radius;
//     public override double GetPerimeter() => 2 * Math.PI * radius;
// }

// class Program
// {
//     static void Main()
//     {
//         List<Shape> shapes = new List<Shape>
//         {
//             new Rectangle(5, 3),
//             new Circle(2)
//         };

//         foreach (var s in shapes)
//             Console.WriteLine($"Площадь = {s.GetArea()}, Периметр = {s.GetPerimeter()}");
//     }
// }




// using System;
// using System.Collections.Generic;

// abstract class Transport
// {
//     public abstract void Move();
// }

// class Car : Transport
// {
//     public override void Move() => Console.WriteLine("Машина едет по дороге");
// }

// class Bicycle : Transport
// {
//     public override void Move() => Console.WriteLine("Велосипед едет по тротуару");
// }

// class Program
// {
//     static void Main()
//     {
//         List<Transport> list = new List<Transport> { new Car(), new Bicycle() };
//         foreach (var t in list)
//             t.Move();
//     }
// }





// using System;
// using System.Collections.Generic;

// abstract class Employee
// {
//     public string Name;
//     public double Salary;

//     public Employee(string name) { Name = name; }
//     public abstract void CalculateSalary();
// }

// class Manager : Employee
// {
//     double baseSalary, bonus;
//     public Manager(string name, double baseSalary, double bonus) : base(name)
//     {
//         this.baseSalary = baseSalary;
//         this.bonus = bonus;
//     }
//     public override void CalculateSalary() => Salary = baseSalary + bonus;
// }

// class Developer : Employee
// {
//     double baseSalary, rate;
//     int hours;
//     public Developer(string name, double baseSalary, double rate, int hours) : base(name)
//     {
//         this.baseSalary = baseSalary;
//         this.rate = rate;
//         this.hours = hours;
//     }
//     public override void CalculateSalary() => Salary = baseSalary + rate * hours;
// }

// class Program
// {
//     static void Main()
//     {
//         List<Employee> employees = new List<Employee>
//         {
//             new Manager("Алия", 100000, 20000),
//             new Developer("Нуржан", 80000, 1000, 5)
//         };

//         foreach (var e in employees)
//         {
//             e.CalculateSalary();
//             Console.WriteLine($"{e.Name}: {e.Salary}");
//         }
//     }
// }




// using System;
// using System.Collections.Generic;

// abstract class Device
// {
//     public abstract void TurnOn();
// }

// class Computer : Device
// {
//     public override void TurnOn() => Console.WriteLine("Компьютер включен");
//     public void RunProgram() => Console.WriteLine("Запущена программа");
// }

// class Smartphone : Device
// {
//     public override void TurnOn() => Console.WriteLine("Смартфон включен");
//     public void MakeCall() => Console.WriteLine("Совершен звонок");
// }

// class Program
// {
//     static void Main()
//     {
//         List<Device> devices = new List<Device> { new Computer(), new Smartphone() };

//         foreach (var d in devices)
//         {
//             d.TurnOn();

//             if (d is Computer c)
//                 c.RunProgram();
//             else if (d is Smartphone s)
//                 s.MakeCall();
//         }
//     }
// }