using PrototypeDP.Models;

var newEmployee = new Employee()
{
    Name = "Adylsha",
    Age = 26,
    Address = new Address()
    {
        Street = "Zambak",
        City = "Istanbul"
    }
};

Console.WriteLine(newEmployee.ToString());
var shallowCopied = newEmployee.DeepCopy();
shallowCopied.Address.City = "Ankara";
Console.WriteLine(new string('-', 30));
Console.WriteLine(newEmployee.ToString());
Console.WriteLine(new string('-', 30));
Console.WriteLine(shallowCopied.ToString());
