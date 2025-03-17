using System;

class Program
{
    /// Convertit un nombre de minutes en heures et minutes.
    static (int, int) ConvertMinutes(int nbMin)
    {
        int hours = nbMin / 60;    /// Calcul le nombre d'heures présentes dans le nombre de minutes.
        int minutes = nbMin % 60;  /// Calcul le nombre de minutes restantes.
        return (hours, minutes);   /// Tuple contenant heures et minutes.
    }

    static void Main()
    {
        Console.Write("Entrez un nombre de minutes : ");
        int input = int.Parse(Console.ReadLine());
        var result = ConvertMinutes(input);
        Console.WriteLine($"Le Résultat est {result.Item1}h : {result.Item2}min");
    }
}
