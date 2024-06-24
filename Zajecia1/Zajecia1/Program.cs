public class Program
{
    public static void Main(string [] args)
    {
        int [] tab = [2, 3, 5];
        double avgas =avg(tab);
        Console.WriteLine(avgas);
    }

    public static double avg(int[] tab)
    {
        int suma = 0;
        int count = 0;
        foreach (var a in tab)
        {
            suma += a;
            count++;
        }

        double avg = suma/count;
        
        return avg;
    }

    public static int max(int[] tab)
    {
        
        int max = tab[1];

        foreach (var a in tab)
        {
            if (a > max)
            {
                max = a;
            }
        }

        return max;
    }
}