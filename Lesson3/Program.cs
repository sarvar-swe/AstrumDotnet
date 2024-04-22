//type casting
//type converting
//operators
//patter matching
//arrays

//1. type casting va type converting
//implicit

// int a = 10;
// long b = a;

// double c = a;

//explicit
// double c = 4.5;
// int f = (int)c;

// Console.WriteLine(f);

//bool b = true; // false;

// uint b = 429496729;

// int son = 10;
// string stringSon = son.ToString();

// Console.WriteLine(stringSon);

//bitwise operators

// & - bitwise logical and (*)
// bool a = false; //1
// bool b = false; //0

// // 1 * 1 = 1
// // 1 * 0 = 0
// // 0 * 0 = 0

// Console.WriteLine(a & b);

// int a = 7;
// int b = 5;
// Console.WriteLine(a & b);

//bitwise logical or (|) - yoki (+)

// int a = 4;
// int b = 8;
// Console.WriteLine(a | b);

// bool a = true;
// bool b = false;
// Console.WriteLine(a | b);

//true | true = true;  1 + 1 = 1;
//true | false = true; 1 + 0 = 1;
//false | true = true; 0 + 1 = 1;
//false | flase = true; 0 + 0 = 0;

//bitwise XOR (^) operator
// bool a = false;
// bool b = false;
// Console.WriteLine(a ^ b);

//left shift and right shift
// int a = 10; // 1010
// Console.WriteLine(a >> 2);

//Declaration patter
// void Print(object a)
// {
//     if(a is int son)
//     {
//         Console.WriteLine($"{a} ning tipi int va u {son} ga o'zlashtirildi");
//     }
//     if(a is long longSon)
//     {
//         Console.WriteLine($"{a} ning tipi long va u {longSon} ga o'zlashtirildi");
//     }

//     if(a is string text)
//     {
//         Console.WriteLine($"{a} ning tipi string va u {text} ga o'zlashtirildi");
//     }
// }

// int a = 10;
// long b = 100;
// string str = "Astrum";
// Print(str);

//switch statement | switch expression


//switch statement

//int haftaKuni = 5;
// switch(haftaKuni)
// {
//     case 1:
//         Console.WriteLine("Dushanba");
//     break;
//     case 2:
//         Console.WriteLine("Seshanba");
//     break;
//     case 3:
//         Console.WriteLine("Chor");
//     break;
//     case 4:
//         Console.WriteLine("Pay");
//     break;
//     case 5:
//         Console.WriteLine("Juma");
//     break;
//     case 6:
//         Console.WriteLine("Shanba");
//     break;
//     case 7:
//         Console.WriteLine("Yak");
//     break;
//     default:
//         Console.WriteLine("Bunday xafta kuni yoq");
//     break;
// }

//switch expression
// int haftaKuni = 5;

// //constant pattern
// var haftaKuniText  = haftaKuni switch
// {
//     1 => "Dushanba",
//     2 => "Se",
//     3 => "Chor",
//     4 => "Pay",
//     5 => "Juma",
//     6 => "Shan",
//     7 => "Yak",
//     _ => "Bunday xafta kuni yoq" // (_) discard patter
// };

// Console.WriteLine(haftaKuniText);

//Relational pattern
// int ball = 105;

//85 - 100 -> Eng zo'r
//60 - 85 -> Yaxshi
//45 - 60 -> O'rtacha
//20 - 45 - Yomon
//0 - 20 - Juda yomon

// var natija = ball switch
// {
//     >= 85 and <= 100 => "Eng zo'r",
//     >= 60 and < 85 => "Yaxshi",
//     >= 45 and < 60 => "O'rtacha",
//     >= 20 and < 45 => "Yomon",
//     >= 0 and < 20 => "Juda yomon",
//     _ => "Ball noto'g'ri kiritildi"
// };

// Console.WriteLine($"{ball} ball {natija} natija");
Console.WriteLine("Astrum");

