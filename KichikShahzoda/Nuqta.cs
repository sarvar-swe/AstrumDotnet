public struct Nuqta
{
    public int X { get; set; }
    public int Y { get; set; }

    public Nuqta(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int IsInside(Nuqta shahzoda, Nuqta malika, Planeta planeta)
    {
        double masofa1 = Math.Sqrt(Math.Pow(shahzoda.X - planeta.X, 2) + Math.Pow(shahzoda.Y - planeta.Y, 2));
        double masofa2 = Math.Sqrt(Math.Pow(malika.X - planeta.X, 2) + Math.Pow(malika.Y - planeta.Y, 2));

        if(masofa1 < planeta.Radius && masofa2 < planeta.Radius)
            return 0;
        else if(masofa1 > planeta.Radius && masofa2 < planeta.Radius || 
                masofa1 < planeta.Radius && masofa2 > planeta.Radius)
            return 1;
        
        return 0;
    }
}