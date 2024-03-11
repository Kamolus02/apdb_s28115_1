using System.Net.Http.Headers;

public class Program
{
    public static void Main(string [] args)
    {
        int i = 2;
        Console.WriteLine("Hello, World!");
        Console.WriteLine(i);
        Console.WriteLine("siema");
    }

    public static int CalculateAvg(int[] a)
    {
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }
        sum /= a.Length;
        return sum;
    }
}