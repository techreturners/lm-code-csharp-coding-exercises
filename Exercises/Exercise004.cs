using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            // Replace the exception statement below with your code!
            //throw new NotImplementedException();

            TimeSpan gigasec = TimeSpan.FromSeconds(Math.Pow(10, 9));
            return dateTime + gigasec;


        }
    }
}
