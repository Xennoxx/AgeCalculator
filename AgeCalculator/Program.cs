using AgeCalculator;

class program
{
    public void Main(string[] args)
    {
        /*DateInput from the class Date Calculation*/
        Console.WriteLine("Welcome!");
        DateCalculation CalculationInput = new();
        Console.WriteLine("Type in you Year of Birth ...");
        CalculationInput.BirthDateInput[2] = Convert.ToInt32(Console.ReadLine);
        Console.WriteLine("Type in you Month of Birth ...");
        CalculationInput.BirthDateInput[1] = Convert.ToInt32(Console.ReadLine);
        Console.WriteLine("Type in you Day of Birth ...");
        CalculationInput.BirthDateInput[0] = Convert.ToInt32(Console.ReadLine);
        /*my pattern menu*/
        PatternMenu MainMenu = new ();
        MainMenu.MyAge();
        MainMenu.PatternHeadLineMethod("Main Menu");
        MainMenu.PatternTextMethod("Claculate how long you lived", 1);
        MainMenu.PatternTextMethod("Calculate how long it takes too be 100 Years old", 2);
        MainMenu.PatternTextMethod("Quit the program?", 3);

    }
}