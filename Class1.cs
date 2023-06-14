public abstract class Transport
{
    protected string _name { get; set; }
    protected int _year { get; set; }
    protected int _weight { get; set; }
    protected string _color { get; set; }


    public Transport() { }

    public Transport(string _name, int year, int weight, string color)
    {
        this._name = _name;
        this._year = year;
        this._weight = weight;
        this._color = color;
    }

    public abstract void Info();
}
class Train : Transport
{
    protected int _carriages { get; set; }
    public Train(string _name, int _year, int _weight, string _color, int carriages) : base(_name, _year, _weight, _color)
    {
        this._carriages = carriages;
    }

    public override void Info()
    {
        Console.WriteLine("Train");
        Console.WriteLine($"Name: {_name}\n" +
                          $"Year: {_year}\n" +
                          $"Weight: {_weight}\n" +
                          $"Color: {_color}");
        Console.WriteLine($"Сarriages: {_carriages}\n");
    }
}
public class Airplane : Transport
{
    protected double _wingLength { get; set; }
    public Airplane(string _name, int _year, int _weight, string _color, double wingLength) : base(_name, _year, _weight, _color)
    {
        this._wingLength = wingLength;
    }

    public override void Info()
    {
        Console.WriteLine("Airplane");
        Console.WriteLine($"Name: {_name}\n" +
                          $"Year: {_year}\n" +
                          $"Weight: {_weight}\n" +
                          $"Color: {_color}");
        Console.WriteLine($"WingLength: {_wingLength:0.00}\n");
    }
}
public class Car : Transport
{
    protected double _speed { get; set; }
    public Car(string _name, int _year, int _weight, string _color, double speed) : base(_name, _year, _weight, _color)
    {
        this._speed = speed;
    }

    public override void Info()
    {
        Console.WriteLine("Car");
        Console.WriteLine($"Name: {_name}\n" +
                          $"Year: {_year}\n" +
                          $"Weight: {_weight}\n" +
                          $"Color: {_color}");
        Console.WriteLine($"Speed: {_speed:0.00}\n");
    }
}
public class Truck : Car
{
    protected double _bodyLength { get; set; }
    public Truck(string _name, int _year, int _weight, string _color, double _speed, double bodyLength) : base(_name, _year, _weight, _color, _speed)
    {
        this._bodyLength = bodyLength;
    }

    public override void Info()
    {
        Console.WriteLine("Truck");
        Console.WriteLine($"Name: {_name}\n" +
                          $"Year: {_year}\n" +
                          $"Weight: {_weight}\n" +
                          $"Color: {_color}\n" +
                          $"Speed: {_speed:0.00}");
        Console.WriteLine($"BodyLength: {_bodyLength:0.00}\n");
    }
}
public class Passenger : Car
{
    protected string _passengerType { get; set; }
    public Passenger(string _name, int _year, int _weight, string _color, double _speed, string passengerType) : base(_name, _year, _weight, _color, _speed)
    {
        this._passengerType = passengerType;
    }

    public override void Info()
    {
        Console.WriteLine("Truck");
        Console.WriteLine($"Name: {_name}\n" +
                          $"Year: {_year}\n" +
                          $"Weight: {_weight}\n" +
                          $"Color: {_color}\n" +
                          $"Speed: {_speed:0.00}");
        Console.WriteLine($"PassengerType: {_passengerType}\n");
    }
}
public class PassengerPlane : Airplane
{
    protected int _seats { get; set; }
    public PassengerPlane(string _name, int _year, int _weight, string _color, double _wingLength, int seats) : base(_name, _year, _weight, _color, _wingLength)
    {
        this._seats = seats;
    }

    public override void Info()
    {
        Console.WriteLine("Airplane");
        Console.WriteLine($"Name: {_name}\n" +
                          $"Year: {_year}\n" +
                          $"Weight: {_weight}\n" +
                          $"Color: {_color}\n" +
                          $"WingLength: {_wingLength:0.00}");
        Console.WriteLine($"Seats: {_seats}\n");
    }
}
public class CargoPlane : Airplane
{
    protected double _capacity { get; set; }

    public CargoPlane(string _name, int _year, int _weight, string _color, double _wingLength, double capacity) : base(_name, _year, _weight, _color, _wingLength)
    {
        this._capacity = capacity;
    }

    public override void Info()
    {
        Console.WriteLine("Cargo Airplane");
        Console.WriteLine($"Name: {_name}\n" +
                          $"Year: {_year}\n" +
                          $"Weight: {_weight}\n" +
                          $"Color: {_color}\n" +
                          $"WingLength: {_wingLength:0.00}");
        Console.WriteLine($"Capacity: {_capacity:0.00}\n");
    }
}