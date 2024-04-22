struct Student
{
    public int Age { get; init; }
    public string Name { get; set; }

    public Student(int age, string name)
    {
        Age = age;
        Name = name;
    }

    // public void ChangeAge(int age)
    // {
    //     Age = age;
    // }
}