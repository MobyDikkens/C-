using System;

namespace Smartphone.Domain.ValueObjects
{
    public class NumberRange
    {
        public int From { get; }
        public int To { get; }

        public NumberRange(
            int from,
            int to)
        {
            if(!IsValidRange(from, to))
                throw new ArgumentOutOfRangeException();

            From = from;
            To = to;
        }

        private static bool IsValidRange(int from, int to)
        {
            return to > from;
        }
    }
}