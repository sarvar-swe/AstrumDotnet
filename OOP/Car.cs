public class Car
{
    public string Name { get; set; }
    public DateTime CreatedTime { get; set; }
    public decimal Price { get; set; }
    public static int speed = 0;

    public Car() { }

    public Car(string name, DateTime createdTime, decimal price)
    {
        Name = name;
        CreatedTime = createdTime;
        Price = price;
    }

    public Car(string name)
    {
        Name = name;
    }

    public int ChangeSpeed(int s)
    {
        speed += s;
        return speed;
    }

    public int GetSpeed()
    {
        return speed;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Created Time: {CreatedTime}, Price: {Price}, Speed: {speed}";
    }
}