public class Teacher : Person
{
    public string Subject { get; set; }
    public Teacher(string name, int age, string subject) : base(name, age)
    {
        Subject = subject;
    }

    public new void DisplayData()
    {
         Console.WriteLine($"Name: {Name}, Age: {Age}, Subject: {Subject}");
    }
}