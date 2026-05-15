using System;
using System.Globalization;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Ley de Gay-Lussac ===");
        Console.WriteLine("Deja en blanco el valor que quieras calcular.\n");

        string t1Input = Leer("T1 (ej: 300K, 25C, 77F): ");
        string p1Input = Leer("P1 (ej: 1atm, 101325Pa, 760Torr): ");
        string t2Input = Leer("T2 (ej: 400K, 30C, 86F): ");
        string p2Input = Leer("P2 (ej: 2atm, 202kPa, 1500Torr): ");

        double? T1 = ParseTemperatura(t1Input);
        double? T2 = ParseTemperatura(t2Input);
        double? P1 = ParsePresion(p1Input);
        double? P2 = ParsePresion(p2Input);

        try
        {
            if (T1 == null)
                T1 = (P1.Value * T2.Value) / P2.Value;
            else if (T2 == null)
                T2 = (P2.Value * T1.Value) / P1.Value;
            else if (P1 == null)
                P1 = (P2.Value * T1.Value) / T2.Value;
            else if (P2 == null)
                P2 = (P1.Value * T2.Value) / T1.Value;
            else
            {
                Console.WriteLine("\nDebes dejar un valor vacío para calcularlo.");
                return;
            }

            Console.WriteLine("\n=== Resultado ===");
            Console.WriteLine($"T1 = {T1:F2} K");
            Console.WriteLine($"P1 = {P1:F4} atm");
            Console.WriteLine($"T2 = {T2:F2} K");
            Console.WriteLine($"P2 = {P2:F4} atm");
        }
        catch
        {
            Console.WriteLine("\nError: verifica que solo dejes un valor vacío.");
        }
    }

    static string Leer(string mensaje)
    {
        Console.Write(mensaje);
        return Console.ReadLine().Trim();
    }

    static double? ParseTemperatura(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return null;

        input = input.Replace(" ", "").ToUpper();
        var match = Regex.Match(input, @"([-+]?\d+(\.\d+)?)([A-Z]+)");

        double valor = double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
        string unidad = match.Groups[3].Value;

        return unidad switch
        {
            "K" => valor,
            "C" => valor + 273.15,
            "F" => (valor - 32) * 5 / 9 + 273.15,
            _ => throw new Exception("Unidad de temperatura no válida")
        };
    }

    static double? ParsePresion(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return null;

        input = input.Replace(" ", "").ToUpper();
        var match = Regex.Match(input, @"([-+]?\d+(\.\d+)?)([A-Z]+)");

        double valor = double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
        string unidad = match.Groups[3].Value;

        return unidad switch
        {
            "ATM" => valor,
            "PA" => valor / 101325,
            "KPA" => valor / 101.325,
            "BAR" => valor / 1.01325,
            "TORR" => valor / 760,
            _ => throw new Exception("Unidad de presión no válida")
        };
    }
}
