using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            double giga = Math.Pow(10, 9);
            return dateTime.AddSeconds(giga);
        }
    }
}
