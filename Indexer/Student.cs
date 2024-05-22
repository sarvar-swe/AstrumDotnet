public class Student
{
    // private readonly string[] students;
    public string Name { get; set; }
    public int Age { get; set; }
    private readonly Student[] students;

    public Student()
    {
        
    }
    public Student(int numberOfStudents)
    {
        // students = new string[numberOfStudents];
        students = new Student[numberOfStudents];
        for(int i = 0; i < numberOfStudents; i++)
        {
            students[i] = new Student();
        }
    }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Student this[int index]
    {
        get
        {
            return students[index];
        }

        set
        {
            students[index] = value;
        }
    }

    // public string this[int index]
    // {
    //     get => students[index];
    //     set => students[index] = value;
    // }
}