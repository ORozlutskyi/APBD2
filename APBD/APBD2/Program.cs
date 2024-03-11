// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Modyfikacja 1");
        Console.WriteLine("Modyfikacja 2");
        Console.WriteLine("Modyfikacja 3");

        int[] liczby = { 1, 2, 3, 4, 5 };
        Console.WriteLine(Srednia(liczby));
        
        int[] liczby2 = { 1, 2, 3, 4, 5, -2, 10, 6 };
        Console.WriteLine(Max(liczby2));
    }

    public static int Srednia(int[] liczby)
    {
        int suma4 = 0;
        for (int i = 0; i < liczby.Length; i++)
        {
            suma4 += liczby[i];
        }

        return suma4 / liczby.Length;
    }
    
    public static int Max(int[] liczby)
    {
        int max = 0;
        for (int i = 0; i < liczby.Length; i++)
        {
            if (max < liczby[i]) max = liczby[i];
        }

        return max;
    }
}
