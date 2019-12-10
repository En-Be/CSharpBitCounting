using System;


class Program
{
    static void Main(string[] args)
    {
        BCounting bCounting = new BCounting(args[0]);
    }
}

class BCounting
{
    int numberToCount = 0;
    string binary;
    int result;
    
    public BCounting(string arg)
    {
        GuardClauses(arg);
        binary = ToBinary();
        result = CountTheOnes();
        Console.WriteLine(Result());
    }

    private void GuardClauses(string arg)
    {
        try
        {
            numberToCount = Convert.ToInt32(arg);
        }
        catch
        {
            throw new ArgumentException("Input must be a positive integer");
        }
    }

    public string ToBinary()
    {
        string binary = "";
        int quotient = numberToCount;
        int remainder;

        do
        {
            remainder = quotient % 2;
            quotient /= 2;
            binary += remainder;
        }
        while(quotient != 0);

        char[] reverseBinary = binary.ToCharArray();
        Array.Reverse(reverseBinary);
        return new string(reverseBinary);
    }

    public int CountTheOnes()
    {
        string s = binary.ToString();
        int ones = 0;

        foreach(char c in s)
        {
            if(c == '1')
            {
                ones++;
            }
        }

        return ones;
    }

    public int Result()
    {
        return result;
    }
}