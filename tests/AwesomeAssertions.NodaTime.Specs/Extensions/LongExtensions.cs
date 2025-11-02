using AwesomeAssertions.Formatting;

namespace AwesomeAssertions.NodaTime.Specs.Extensions
{
    public static class LongExtensions
    {
        public static string AsFormatted(this long value)
        {
            Int64ValueFormatter? formatter = new();
            FormattedObjectGraph graph = new(1);
            formatter.Format(value, graph, null, null);

            return graph.ToString();
        }
    }
}
