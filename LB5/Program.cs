namespace LB5;

class Program
{
    static void Main(string[] args)
    {
        Person a = new Person();
        a.Name = "John";
        a.Surname = "Doe";
        a.DateOfBirth = DateTime.Now;
        Console.WriteLine(a.ToString());
        Console.WriteLine(a.ToShortString());

        Console.ReadKey();
    }
}