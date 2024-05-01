public class Teacher : Person
{
    public string Subject { get; set; }
    public Teacher(string name, int age, string subject) : base(name, age)
    {
        Subject = subject;
    }

    public override void DisplayData()
    {
        Console.WriteLine($"Teacher -> Name: {Name}, Age: {Age}, Subject: {Subject}");
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Subject: {Subject}";
    }
}