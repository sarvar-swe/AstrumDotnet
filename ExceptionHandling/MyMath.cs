public static class MyMath
{
    public static bool ValidateNumber(int num)
    {
        if(num < 0)
        {
            throw new NegativeNumberException("Manfiy son kiritish mumkin emas");
        }

        return true;
    }
}