using AgeCalculator;

class program
{
    public static void Main(string[] args)
    {
        /*Show you input*/
        DateCalculation calculationInput = new();
        /*BirthDate Input*/
        Console.WriteLine("Welcome!");
        Console.WriteLine("Type in you Year of Birth ...");
        calculationInput.BirthDateInput[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type in you Month of Birth ...");
        calculationInput.BirthDateInput[1] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type in you Day of Birth ...");
        calculationInput.BirthDateInput[2] = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        bool Check = true;
        do
        {
            /*New Objects*/
            PatternMenu MainMenu = new();
            /*MainMenu*/
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            calculationInput.MyAge(); // Output of my age
            MainMenu.PatternHeadLineMethod("Main Menu");
            MainMenu.PatternTextMethod("Claculate how long you lived total", 1);
            MainMenu.PatternTextMethod("Calculate how long it takes too be 100 Years old", 2); //Yea kinda useless
            MainMenu.PatternTextMethod("Calculate how old you are in Cyberpunk 2077", 3);
            MainMenu.PatternTextMethod("Quit the program?", 4);
            int MainInputNumber = 0;
            MainInputNumber = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (MainInputNumber == 1)
            {
                calculationInput.MyAgeTotalDays();
                Thread.Sleep(5000);
                Console.Clear();
            }
            else if (MainInputNumber == 2)
            {
                calculationInput.MeInHundretDays();
                Thread.Sleep(5000);
                Console.Clear();
            }
            else if (MainInputNumber == 3)
            {
                calculationInput.Cyberpunk();
                Thread.Sleep(5000);
                Console.Clear();
            }
            else if (MainInputNumber == 4)
            {
                Check = false;
            }
            else
            {
                Console.WriteLine("Error: number or sign is not valid");
                Thread.Sleep(5000);
                Console.Clear();
            }
        } while (Check == true);
    }
}