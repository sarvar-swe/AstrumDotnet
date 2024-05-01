namespace AstrumDotnet.Abstraction.Abstract;
public class MyMath : AbstractMyMath
{
    public override int Add(int a, int b)
    {
        return a + b;
    }

    public override int Divide(int a, int b)
    {
        return a / b;
    }

    public override int Multiply(int a, int b)
    {
        return a * b;
    }

    public override int Subtract(int a, int b)
    {
        return a - b;
    }
}