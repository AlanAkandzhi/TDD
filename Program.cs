using System;

namespace Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: dotnet run --project convert <number> -mm/-cm/-m");
                return;
            }

            try
            {
                double inches = double.Parse(args[0]);
                string unit = args[1];
                double result = Converter.ConvertToUnit(inches, unit);

                Console.WriteLine($"{result} {unit.Replace("-", "")}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
