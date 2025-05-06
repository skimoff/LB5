namespace LB5;
public enum TypeOfWork
{
    Home,
    Business,
    Server
}
public class Computer
{
    private Person _person;
    private TypeOfWork _type;
    private string _ip;
    private Device[] _device;

    public Computer(Person person, TypeOfWork type, string ip, Device[] device)
    {
        _person = person;
        _type = type;
        _ip = ip;
        _device = device ?? Array.Empty<Device>();
    }

    public Computer()
    {
        _person = new Person();
        _type = TypeOfWork.Home;
        _ip = "0.0.0.0";
        _device = new Device[0];
    }

    public Person Person
    {
        get => _person;
        set => _person = value;
    }

    public TypeOfWork Type
    {
        get => _type;
        set => _type = value;
    }

    public string Ip
    {
        get => _ip;
        set
        {
            _ip = value;
        }
    }

    public Device[] Device
    {
        get => _device;
        set => _device = value;
    }

    public double TotalPrice
    {
        get
        {
            double total = 0;
            foreach (var i in _device)
                total+=i.price;
            return total;
        }
    }
    public void AddDevice(params Device[] newDevice){
        if (newDevice == null || newDevice.Length == 0) return;
        int oldLength = _device.Length;
        Array.Resize(ref _device, oldLength + newDevice.Length);
        Array.Copy(newDevice, 0, _device, oldLength, newDevice.Length);
    }
    public bool this[TypeOfWork type] => _type == type;

    public override string ToString()
    {
        return $"{_person}\nПризначення: {_type}, IP: {_ip}\nПристрої:\n{_device.ToString()}";
    }

    public string ToShortString()
    {
        return $"{_person.ToShortString()}, Призначення: {_type}, IP: {_ip}, Загальна вартість пристроїв: {TotalPrice}";
    }
}