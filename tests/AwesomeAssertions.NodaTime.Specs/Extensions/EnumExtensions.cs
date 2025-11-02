using System;
using AwesomeAssertions.Formatting;

namespace AwesomeAssertions.NodaTime.Specs.Extensions
{
    public static class EnumExtensions
    {
        public static string AsFormatted(this Enum value)
        {
            EnumValueFormatter formatter = new();
            FormattedObjectGraph graph = new(1);
            formatter.Format(value, graph, null, null);

            return graph.ToString();
        }
    }
}
