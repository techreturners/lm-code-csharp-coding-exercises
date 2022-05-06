using System;
namespace Exercises
{
    public class Exercise004
    {
        private const double _AGIGASECOND = 1000000000;

        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            return dateTime.AddSeconds(_AGIGASECOND);
        }
    }
}
