//Call by value and call by reference

// void Change(ref int a)
// {
//     a = 10;
// }

// int b = 3;

// Change(ref b);
// Console.WriteLine(b);

// void ChangeString(ref string str)
// {
//     str = "Academy";
// }

// string str = "Astrum";

// ChangeString(ref str);

// Console.WriteLine(str);

// void Change(out int a)
// {
//     a = 10;
// }

// int b;

// Change(out b);

// Console.WriteLine(b);

// void Swap(out int a, out int b)
// {
//     int t = a;
//     a = b;
//     b = t;
// }

// void Swap(ref int a, ref int b)
// {
//     int t = a;
//     a = b;
//     b = t;
// }

// int a = 10, b = 5;

// Swap(ref a, ref b);

// Console.WriteLine("a = {0}, b = {1}", a, b);

// bool isParsed = int.TryParse(Console.ReadLine()!, out int a);

// Console.WriteLine(isParsed);
// Console.WriteLine(a);

// int[] arr = new int[10];

// arr[0] = 1;


// Student students = new Student(3);

// students[0] = "Akbar";
// students[1] = "Kamron";
// students[2] = "Bahodir";

// for(int i = 0; i < 3; i++)
// {
//     Console.WriteLine(students[i]);
// }

int[] arr = new int[3];

Student[] students = new Student[3];

// students[0].Name = "Akbar";
// students[0].Age = 20;
students[0] = new Student("Akbar", 20);

// students[1].Name = "Kamron";
// students[1].Age = 19;
students[1] = new Student("Kamron", 19);

// students[2].Name = "Bahodir";
// students[2].Age = 22;
students[2] = new Student("Bahodir", 22);

for(int i = 0; i < 4; i++)
{
    Console.WriteLine($"Name: {students[i].Name}, Age: {students[i].Age}");
}