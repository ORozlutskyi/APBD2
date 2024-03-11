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
    }

    public static int Srednia(int[] liczby)
    {
        int suma = 0;
        for (int i = 0; i < liczby.Length; i++)
        {
            suma += liczby[i];
        }

        return suma / liczby.Length;
    }
}
