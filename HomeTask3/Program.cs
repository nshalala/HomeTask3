using HomeTask3.Models;

Student me = new Student("Shalala", "Nasirli", "P137", 88, false);

Console.WriteLine($"{me.Info()}");
Console.WriteLine($"{me.FullName()}");
Console.WriteLine($"{me.SecondChance()}");
