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
        date = DateTime.Now;
    }
    
    public override string ToString()
    {
        return $"Назва: {nameDevice}, Вартість: {price}, Дата випуску: {date}";
    }
}