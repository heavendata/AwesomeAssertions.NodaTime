using AwesomeAssertions.Formatting;
using AwesomeAssertions.NodaTime.Formatters;
using NodaTime;

namespace AwesomeAssertions.NodaTime.Specs.Extensions
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
