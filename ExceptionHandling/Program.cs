// try
// {
//     var sonlar = Console.ReadLine()
//         .Split(' ', StringSplitOptions.RemoveEmptyEntries)
//         .Select(int.Parse)
//         .ToArray();
    
//     Console.WriteLine(sonlar[0] / sonlar[1]);
// }
// catch (FormatException)
// {
//     Console.WriteLine("Kiritilgan input to'g'ri formatda emas");
// }
// catch (DivideByZeroException)
// {
//     Console.WriteLine("0 ga bo'lish bilan xatolik");
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error: " + ex.Message);
// }


try
{
    var son = int.Parse(Console.ReadLine());
    MyMath.ValidateNumber(son);
}
catch(OutOfMemoryException ex)
{
    Console.WriteLine(ex.Message);
}