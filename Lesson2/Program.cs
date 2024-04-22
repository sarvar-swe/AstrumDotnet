// int son = 10;

// int class = 10; // error


//literal vs variable

// string str = "Hello"; // str - string variable, "Hello" - string literal

// int son = 10; // son - integer variable, 10 - integer literal

// double son2 = 45.5; // son2 - double variable, 45.5 - double literal

// float son3 = 4.5F;

// decimal son4 = 34.7M;

//integer literal
//byte
//sbyte
//int
//uint
//nint
//nuint
//long
//ulong
//short
//ushort

//real or floating-point literals
//float
//double
//decimal

//boolean literal
// bool a = true;
// bool b = false; 

//character literal
// char harf = 'a';
// char belgi = '#';






//is string immutable or mutable?

//Garbage collector
// string str2 = "Astrum";

// str2 = "Academy";
// // str2[1] = 'b';

// Console.WriteLine(str2);

// int age = 12;
// int age2 = 15;

// string str = string.Format("Mening yoshim {0} da, uning yoshi {1} da", age, age2);
// Console.WriteLine("Mening yoshim {0} da, uning yoshi {1} da", age, age2);


// var list = str.Split(';');

// for(int i = 0; i < list.Length; i++)
// {
//     Console.WriteLine(list[i]);
// }

// var sonlar = Console.ReadLine().Split(' ');

// int son1 = int.Parse(sonlar[0]);
// int son2 = int.Parse(sonlar[1]);

// Console.WriteLine(son1 + son2);



// Console.WriteLine(str.Substring(7, 2));

// string str1 = "World";
// string str2 = "hello";

// Console.WriteLine(string.Compare(str2, str1));

//2 - 1 = 1
//1 - 2 = -1



// string str2 = str.Replace("Astrum", "AstoDev");

// Console.WriteLine(str.Contains("School"));

// var list = str.Split(' ');

// string str2 = string.Join(',', list);

// Console.WriteLine(str2);




// Console.WriteLine(str);
// Console.WriteLine(str.TrimEnd());

// Console.WriteLine(str.Remove(7, 3));
// Console.WriteLine(str);

// Console.WriteLine(str.ToLower());
// Console.WriteLine(str.ToUpper());
// Console.WriteLine();

// string str = "Astrum";

// // Console.WriteLine(str.PadRight(10, '%'));

// var harflar = str.ToCharArray(); // ['A', 's', 't', 'r', 'u', 'm']

// for(int i = 0; i < harflar.Length; i++)
// {
//     Console.WriteLine(harflar[i]);
// }

// string str = "Atstrum IT AcademyA";

// Console.WriteLine(str.IndexOf("A"));
// Console.WriteLine(str.LastIndexOf("A"));