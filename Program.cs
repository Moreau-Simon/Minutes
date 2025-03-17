using System;

class Program
{
    static (int, int) ConvertMinutes(int nbMin)
    {
        int hours = nbMin / 60;
        int minutes = nbMin % 60;
        return (hours, minutes);
    }

    static void Main()
    {
        Console.Write("Entrez un nombre de minutes : ");
        int input = int.Parse(Console.ReadLine());
        var result = ConvertMinutes(input);
        Console.WriteLine($"Le Résultat est {result.Item1}h : {result.Item2}min");
    }
}
