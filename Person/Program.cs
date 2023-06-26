using classes;
var per1 = new Person()
{
    FirstName = Console.ReadLine(), 
    LastName = Console.ReadLine(),
    Age = Convert.ToInt32(Console.ReadLine()),
    Address = Console.ReadLine(),
};

Console.WriteLine($"My name is {per1.GetName()}");
Console.WriteLine($"My birth year is {per1.GetYear()}");
