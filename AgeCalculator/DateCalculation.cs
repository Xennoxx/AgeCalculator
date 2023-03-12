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
        public void MyAge()
        {
            DateTime Birthday = new(BirthDateInput[0], BirthDateInput[1], BirthDateInput[2]);
            Console.WriteLine("You BirthDate: " + Birthday.ToString());
        }
        /*//Chunk 16 
  using System;
  public static class Clock
{
    public static int Past(int h, int m, int s)
    {
        return (int)(new TimeSpan(h, m, s)).TotalMilliseconds;
    }
}*/
    }
}
