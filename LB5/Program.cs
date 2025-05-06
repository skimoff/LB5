namespace LB5;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var person = new Person("Іван", "Іваненко", new DateTime(1995, 5, 22));
        var devices = new Device[]
        {
            new Device("Монітор", 3000, new DateTime(2020, 1, 1)),
            new Device("Клавіатура", 800, new DateTime(2021, 2, 15))
        };

        Computer comp = new Computer(person, TypeOfWork.Business, "192.168.0.1", devices);

        Console.WriteLine($"Скорочена інформація: {comp.ToShortString()}");
        Console.WriteLine($"\nПовна інформація:{comp}");
        
        Console.WriteLine($"TypeOfWork.Home: {comp[TypeOfWork.Home]}");
        Console.WriteLine($"TypeOfWork.Business: {comp[TypeOfWork.Business]}");
        Console.WriteLine($"TypeOfWork.Server: {comp[TypeOfWork.Server]}");

        
        comp.AddDevice(new Device("Мишка", 500, DateTime.Now));

        Console.WriteLine($"\nПісля додавання пристроїв:{comp}");
        
        Computer[] computers = new Computer[5];
        computers[0] = comp;
        for (int i = 1; i < 5; i++)
        {
            computers[i] = new Computer(
                new Person($"Ім’я{i}", $"Прізвище{i}", DateTime.Now.AddYears(-20 - i)),
                TypeOfWork.Home,
                $"192.168.0.{i + 1}",
                new Device[] { new Device("USB-накопичувач", 300, DateTime.Now) }
            );
        }

        Console.WriteLine("\nIP-адреси всіх комп’ютерів:");
        foreach (var c in computers)
        {
            Console.WriteLine(c.Ip);
        }
        
        int maxDevices = 0;
        foreach (var c in computers)
            if (c.Device.Length > maxDevices)
                maxDevices = c.Device.Length;

        Console.WriteLine("\nКомп’ютери з найбільшою кількістю пристроїв:");
        foreach (var c in computers)
            if (c.Device.Length == maxDevices)
                Console.WriteLine(c.ToShortString());

        Console.ReadKey();
    }
}