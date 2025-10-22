// // task 1

// using System;

// class Students
// {
//     public string name;
//     public string group;
//     public int grade;

//     public Students(string name, string group, int grade)
//     {
//         this.name = name;
//         this.group = group;
//         this.grade = grade;
//     }

//     public string ShowInfo()
//     {
//         return $"Hello, my name is {name} and I study in {group}. My grade is {grade}.";
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Students student1 = new Students("Aribzhan", "CS101", 90);
//         Students student2 = new Students("Azamat", "CS102", 85);

//         Console.WriteLine(student1.ShowInfo());
//         Console.WriteLine(student2.ShowInfo());
//     }
// }

// // task 2

// using System;


// class Cars
// {
//     public string brand;
//     public string model;
//     public int year;
    
    
//     public Cars(string brand, string model, int year)
//     {
//         this.brand = brand;
//         this.model = model;
//         this.year = year;
//     }
    
    
//     public string  StartEngine()
//     {
//         return $"Car {brand} {model} started up";
//     }
    
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Cars car1 = new Cars("BMW", "M5", 2022);
//         Cars car2 = new Cars("Audi", "A7", 2020);
        
//         Console.WriteLine(car1.StartEngine());
//         Console.WriteLine(car2.StartEngine());
//     }
// }





// // task 3
// using System;
// class Games
// {
//     public string title;
//     public string genre;
//     public double rating;
    
//     public Games(string title,string genre, double rating)
//     {
//         this.title = title;
//         this.genre = genre;
//         this.rating = rating;
//     }
    
    
//     public string Play()
//     {
//         return $"Your are palying game {title} and genre of this game is {genre}";
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Games game1 = new Games("FIFA 2026", "foodball", 5.0);
        
//         Console.WriteLine(game1.Play());
//     }
// }










// // task 4
// using System;
// class Lamp
// {
//     public bool isOn;

//     public void TurnOn()
//     {
//         isOn = true;
//     }

//     public void TurnOff()
//     {
//         isOn = false;
//     }

//     public void ShowStatus()
//     {
//         if (isOn)
//             Console.WriteLine("Lamp  turned on");
//         else
//             Console.WriteLine("Lamp turned off");
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Lamp myLamp = new Lamp(); 

//         myLamp.ShowStatus(); 
//         myLamp.TurnOn();      
//         myLamp.ShowStatus(); 
//         myLamp.TurnOff();     
//         myLamp.ShowStatus();  
//     }
// }


// // task 5
// using System;
//  class Employee
//  {
//     public string name;
//     public string position;
//     public int salary;
    
//     public Employee(string name, string position, int salary)
//     {
//         this.name = name;
//         this.position = position;
//         this.salary = salary;
//     }
    
//     public string IncreaseSalary(double percent)
//     {
//         double result = salary + (salary * percent / 100 );
//         return $"Salary succesfylli increased! your salary: {result}";
//     }
    
//  }
 
//  class Program
//  {
//      public static void Main(string[] args)
//      {
//          Employee employer1 = new Employee("Aribzhan", "developer", 500000);
//          double percent = 15;
//          Console.WriteLine(employer1.IncreaseSalary(percent));
//      }
//  }







