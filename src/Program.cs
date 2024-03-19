
while (true)
{
    Console.WriteLine($" Enter a temperature and its unit (C or F), or type 'Quit' to exit:");
    string? input = Console.ReadLine();
    try
    {

        if (input is null || input.Equals("Quit", StringComparison.CurrentCultureIgnoreCase) || input == "")
        {
            Console.WriteLine(" Program terminated ");
            break;
        }
        string[] subInput = input.Split(' ');
        double degree = Convert.ToDouble(subInput[0]);
        char unit = Convert.ToChar(subInput[1]);

        if (unit.ToString().Equals("C", StringComparison.CurrentCultureIgnoreCase) || unit.ToString().Equals("F", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.Write($"Converted: {degree} {unit.ToString().ToUpper()} = ");
            Console.WriteLine(Temperature.TempConvert(unit.ToString(), Convert.ToInt16(degree)));
        }
        else
        {
            Console.WriteLine($"Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
            continue;
        }

    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a numeric temperature.");
        continue;
    }
    catch (Exception)
    {
        Console.WriteLine("something went wrong, dude!");
        continue;
        throw;
    }
}

class Temperature()
{
    public static string TempConvert(string unit, int amount)
    {
        if (unit.ToUpper() == "F")
        {
            int result = (amount - 32) * 5 / 9;
            return result.ToString() + " C";
        }
        else if (unit.ToUpper() == "C")
        {
            int result = (amount * 9 / 5) + 32;
            return result.ToString() + " F";

        }
        else
        {
            return "";
        }
    }
}

