var testlarSoni = int.Parse(Console.ReadLine());

for(int i = 0; i < testlarSoni; i++)
{
    int count = 0;

    var koordinatalar = Console.ReadLine()
                               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

    Nuqta shahzoda = new Nuqta(koordinatalar[0], koordinatalar[1]);
    Nuqta malika = new Nuqta(koordinatalar[2], koordinatalar[3]);
    
    var planetalarSoni = int.Parse(Console.ReadLine());

    for(int j = 0; j < planetalarSoni; j++)
    {
        var p = Console.ReadLine()
                             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse)
                             .ToArray();
        
        Planeta planeta = new Planeta(p[0], p[1], p[2]);

        Nuqta isInside = new Nuqta();

        count += isInside.IsInside(shahzoda, malika, planeta);
    }

    Console.WriteLine($"Count = {count}");
}