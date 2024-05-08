public static class StringExtension
{
    public static string MyToUpper(this string str)
    {
        return str.ToUpper();
    }

    public static void CountAandY(this string str, char a, char b)
    {
        Console.WriteLine($"Count {a} = {str.Count(x => x == a)}");
        Console.WriteLine($"Count {b} = {str.Count(x => x == b)}");
    }

    public static void StartAWords(this string str)
    {
        var str2 = str.Split(' ');
        for (int i = 0; i < str2.Length; i++)
        {
            if (str2[i].StartsWith('A'))
            {
                Console.WriteLine(str2[i]);
            }
        }
    }

    public static void MyEndWords(this string str, string str2)
    {
        var list = str.Split();

        for (byte i = 0; i < list.Length; i++)
        {
            if (list[i].EndsWith(str2))
            {
                Console.WriteLine($"Words: {list[i]}");
            }
        }
    }

    public static void ContainsInfo(this string str)
    {
        var list = str.Split(' ');

        for (int i = 0; i < list.Length; i++)
        {
            if (list[i].Contains("Info"))
            {
                Console.WriteLine(list[i]);
            }
        }
    }

    public static void PrintU(this string str)
    {
        string unlilar = "AEUIOaeuio";
        int sum = 0;
        for(int i = 0; i < str.Length; i++)
        {
            if(unlilar.Contains(str[i]))
            {
                sum++;
            }
        }
    Console.WriteLine(sum);
    }

    public static void myReverse(this string str){
        char[] chars= str.ToCharArray();
        Array.Reverse(chars);
        Console.WriteLine(chars);
    }
    public static void MyLengthForEachElement(this string str){
        string[] Words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int counter = 0;
        foreach(string word in Words){
            counter = 0;
            for(int j = 0; j < word.Length; j++){
                counter++;
            }
            Console.Write(word + ": ");
            Console.WriteLine(counter);
        }
    }
} 