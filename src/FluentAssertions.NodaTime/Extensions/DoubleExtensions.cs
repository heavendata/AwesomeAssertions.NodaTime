using System;

namespace FluentAssertions.NodaTime.Extensions
{
    internal static class DoubleExtensions
    {
        internal static bool IsApproximatelyEqual(this double value, double expected, double precision) =>
            Math.Abs(value - expected) <= precision;
    }
}
