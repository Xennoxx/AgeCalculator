using AgeCalculator;

class program
{
    public static void Main(string[] args)
    {
        /*Show you input*/
        DateCalculation calculationInput = new();
        /* 
        string[] Showing = new string[3] 
        {
            Showing[0] = CalculationInput.BirthDateInput[0].ToString(),
            Showing[1] = CalculationInput.BirthDateInput[1].ToString(),
            Showing[2] = CalculationInput.BirthDateInput[2].ToString(),
        }; 
        */
        /*BirthDate Input*/
        Console.WriteLine("Welcome!");
        Console.WriteLine("Type in you Year of Birth ...");
        calculationInput.BirthDateInput[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type in you Month of Birth ...");
        calculationInput.BirthDateInput[1] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type in you Day of Birth ...");
        calculationInput.BirthDateInput[2] = Convert.ToInt32(Console.ReadLine());

        /*New Objects*/
        PatternMenu MainMenu = new ();
        /*MainMenu*/
        calculationInput.MyAge(); // Output of my age
        MainMenu.PatternHeadLineMethod("Main Menu");
        MainMenu.PatternTextMethod("Claculate how long you lived", 1);
        MainMenu.PatternTextMethod("Calculate how long it takes too be 100 Years old", 2);
        MainMenu.PatternTextMethod("Quit the program?", 3);
        Thread.Sleep(8000);
    }
}