public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Score { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public static bool operator >(Student student1, Student student2)
    {
        return student1.Age > student2.Age;
    }

    public static bool operator <(Student student1, Student student2)
    {
        return student1.Age < student2.Age;
    }



    public static bool operator ==(Student student1, Student student2)
    {
        return student1.Name == student2.Name && student1.Age == student2.Age;
    }

    public static bool operator !=(Student student1, Student student2)
    {
        if(!student1.Equals(student2))
            return true;
        
        return false;
    }

    public override bool Equals(object obj)
    {
        Student student = (Student)obj;

        if(Name == student.Name && Age == student.Age)
            return true;
        
        return false;
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }
}