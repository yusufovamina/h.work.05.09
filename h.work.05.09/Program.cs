Device dev = new("Device1");
dev.Show();
dev.Desc();
dev.Sound();
Console.WriteLine();

Kettle kettle1 = new("Kettle", "Tefal");
kettle1.Show();
kettle1.Desc();
kettle1.Sound();
Console.WriteLine();

Microwave micrw = new("Microwave","Borsh", 120);
micrw.Show();
micrw.Desc();
micrw.Sound();
Console.WriteLine();

Car car1 = new("Car", "Porshe");
car1.Show();
car1.Desc();
car1.Sound();
Console.WriteLine();

Ship ship1 = new("Ship", "Yacht");
ship1.Show();
ship1.Desc();
ship1.Sound();

class Device
{
    protected string Name;

    public Device(string name)
    {
        Name = name;
    }

    public virtual void Sound()
    {
        Console.WriteLine($"{Name} sound.");
    }

    public void Show()
    {
        Console.WriteLine($"Device name: {Name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine($"Description: {Name}");
    }
}

class Kettle : Device
{
    private string Brand;

    public Kettle(string name, string brand) : base(name)
    {
        Brand = brand;
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} pshhhhhhh.");
    }

    public override void Desc()
    {
        Console.WriteLine($"Description: {Name}, Brand : {Brand}");
    }
}

class Microwave : Device
{
    private int Power;
    private string Brand;

    public Microwave(string name,string brand, int power) : base(name)
    {
        Power = power;
        Brand = brand;
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} jjjjjjjjj.");
    }

    public override void Desc()
    {
        Console.WriteLine($"Description: {Name}, Brand: {Brand}, Power: {Power} Wt");
    }
}

class Car : Device
{
    private string Model;

    public Car(string name, string model) : base(name)
    {
        Model = model;
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} brrrrmmmmmm.");
    }

    public override void Desc()
    {
        Console.WriteLine($"Device: {Name}, Model: {Model}");
    }
}

class Ship : Device
{
    private string Type;

    public Ship(string name, string type) : base(name)
    {
        Type = type;
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} tidiiiiiim.");
    }

    public override void Desc()
    {
        Console.WriteLine($"Description: {Name}, Type: {Type}");
    }
}