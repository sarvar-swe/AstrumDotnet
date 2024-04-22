
// using System.Diagnostics;
// using System.Text;

// Stopwatch st = new Stopwatch();
// st.Start();
// // string str = "";
// StringBuilder str = new StringBuilder();

// for(int  i = 0; i < 1000; i++)
// {
//     str.AppendLine("Astrum");
// }

// st.Stop();
// Console.WriteLine(str);

// Student student = new Student(20, "Akbar");
// Student student2 = new Student();

// // student2.Age = 23;
// // student2.ChangeAge(24);
// student2.Name = "Kamol";

// string name = student2.Name;

// Console.WriteLine(student2.Age);

// DayOfWeek days = DayOfWeek.Monday | DayOfWeek.Wednesday;

// Console.WriteLine(days);

// int[] kunlar = new int[7];

// kunlar[0] = 1;
// kunlar[1] = 2;
// kunlar[2] = 3;
// kunlar[3] = 4;
// kunlar[4] = 5;
// kunlar[5] = 6;
// kunlar[6] = 7;

// Console.WriteLine(kunlar.Length);

// int[] kunlar = {1, 2, 3, 4, 5, 6, 7};

// var kunlar2 = kunlar.Where(x => x > 3);

// foreach(var element in kunlar2)
// {
//     Console.WriteLine(element);
// }

// double[ , ] kunlar = 
// {
//     {1.6, 2, 3, 4},
//     {5 , 6, 7, 8},
//     {6 , 7, 8, 9}
// };

// Console.WriteLine(kunlar.GetLength(0));
// Console.WriteLine(kunlar.GetLength(1));

// for(int i = 0; i < kunlar.GetLength(0); i++)
// {
//     for(int j = 0; j < kunlar.GetLength(1); j++)
//     {
//         Console.Write(kunlar[i, j] + " ");
//     }
//     Console.WriteLine();
// }


int[][] jaggedArray = 
{
    new int[] {1, 2, 3, 5, 6},
    new int[] {4, 5},
    new int[] {8, 10, 11}
};

for(int i = 0; i < jaggedArray.Length; i++)
{
    for(int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();   
}

// jaggedArray[0] = new int[7];
// jaggedArray[1] = new int[2];
// jaggedArray[3] = new int[3];
// jaggedArray[4] = new int[6];



