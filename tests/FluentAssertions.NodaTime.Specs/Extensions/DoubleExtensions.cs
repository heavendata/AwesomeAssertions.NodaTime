using FluentAssertions.Formatting;

namespace FluentAssertions.NodaTime.Specs.Extensions
{
    public static class DoubleExtensions
    {
        public static string AsFormatted(this double value)
        {
            DoubleValueFormatter formatter = new();
            FormattedObjectGraph graph = new(1);
            formatter.Format(value, graph, null, null);

            return graph.ToString();
        }
    }
}
