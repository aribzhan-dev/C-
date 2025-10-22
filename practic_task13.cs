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