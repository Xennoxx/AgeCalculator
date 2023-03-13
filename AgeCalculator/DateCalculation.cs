using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    internal class DateCalculation
    {
        public int[] BirthDateInput = new int[3];
        DateTime Birthday;
        public void MyAge()
        {
            Birthday = new (BirthDateInput[0], BirthDateInput[1], BirthDateInput[2]);
            Console.WriteLine("You BirthDate: ");
            Console.WriteLine(Birthday.ToString());
        }
        public void MyAgeTotalDays()
        {
            TimeSpan myAgeTotal = DateTime.Now.Subtract(Birthday);
            Console.WriteLine("You total age time: " + myAgeTotal.Days);
        }
        public void MeInHundretDays()
        {
            Console.WriteLine(Birthday.AddYears(100));
        }
        public void Cyberpunk()
        {
        TimeSpan myAgeTotal = DateTime.Now.Subtract(Birthday);
        TimeSpan cyberpunk = new DateTime(2077,1,1).Subtract(Birthday);
            Console.WriteLine("You need too live " + (cyberpunk.Days - myAgeTotal.Days) + " days until we have the Cyberpunk 2077 scenario. :))");
        }
    }
}
