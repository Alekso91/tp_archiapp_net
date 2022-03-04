class Program
{
    public static void Main()
    {
        int x = 30;
        Fibonacci f = new Fibonacci();
        Console.WriteLine("Hello, World!" + f.Calcul(30) );
    }
}

class Fibonacci: Isuite
{
    public int Calcul(int n)
    {
        int firstNumber = 0, secondNumber = 1, result = 0;
        if (n == 0) return 0;
        if (n == 1) return 1;
        for (int i = 2; i <= n; i++)
        {
            result = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondnumber = result;
        }
        return result;
    }
}

interface Isuite
{
    List<int> Calcul(int x);
}

