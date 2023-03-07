using AgeCalculator;

class program
{
    public void Main(string[] args)
    {
        Console.WriteLine("Welcome!");
        Console.WriteLine("Type in you Birth Date ...");
        string BirthDate = "";
        PatternMenu MainMenu = new ();
        MainMenu.MyAge(BirthDate);
        MainMenu.PatternHeadLineMethod("Main Menu");
        MainMenu.PatternTextMethod("Claculate how long you lived", 1);
        MainMenu.PatternTextMethod("Calculate how long it takes too be 100 Years old", 2);
        MainMenu.PatternTextMethod("Quit the program?", 3);

    }
}