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
        var result = ConvertMinutes(130);
        Console.WriteLine($"{result.Item1}:{result.Item2}");
    }
}
