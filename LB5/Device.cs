namespace LB5;

public class Device
{
    public string nameDevice { get; set; }
    public float price { get; set; }
    public DateTime date { get; set; }

    public Device(string nameDevice, int price, DateTime date)
    {
        this.nameDevice = nameDevice;
        this.price = price;
        this.date = date;
    }

    public Device()
    {
        nameDevice = "Noname";
        price = 0;
        date = new DateTime(0,0,0);
    }
    
    public override string ToString()
    {
        return "Device name"+' '+nameDevice+" \nPrice"+' '+price+"\nDate v"+' '+date;
    }
}