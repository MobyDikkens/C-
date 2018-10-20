using System;

namespace Smartphone.Domain.ValueObjects
{
    public class FloatingNumberRange
    {
        public double From { get; }
        public double To { get; }

        public FloatingNumberRange(
            double from,
            double to)
        {
            if(!IsValidRange(from, to))
                throw new ArgumentOutOfRangeException();

            From = from;
            To = to;
        }

        private static bool IsValidRange(
            double from,
            double to)
        {
            return to > from;
        }
    }
}