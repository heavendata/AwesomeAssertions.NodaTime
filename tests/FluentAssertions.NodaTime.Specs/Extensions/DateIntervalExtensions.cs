using FluentAssertions.Formatting;
using FluentAssertions.NodaTime.Formatters;
using NodaTime;

namespace FluentAssertions.NodaTime.Specs.Extensions
{
    public static class DateIntervalExtensions
    {
        public static string AsFormatted(this DateInterval value)
        {
            DateIntervalValueFormatter formatter = new();
            FormattedObjectGraph graph = new(1);
            formatter.Format(value, graph, null, null);

            return graph.ToString();
        }
    }
}
