using System;

namespace jaytwo.FluentDateTimePrecision
{
    public class NullableDateTimeFluentTruncationBuilder : INullableDateTimeFluentTruncationBuilder
    {
        public DateTime? Value { get; }

        public NullableDateTimeFluentTruncationBuilder(DateTime? value)
        {
            Value = value;
        }
    }
}
