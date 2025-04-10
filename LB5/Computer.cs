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
        _device = device;
    }

    public Computer()
    {
        _person = new Person();
        _type = TypeOfWork.Home;
        _ip = "0.0.0.0";
        _device = new Device[0];
    }
    
    // public override string ToString()
    // {
    //     string s = _person.ToString()+"\nType"+_type+"\nIp"+_ip+"\n"+_device;
    //     foreach (Device device in _device)
    //     {
    //         s += device.ToString()+"\n";
    //     }
    //     return s;
    // }
    
    
}