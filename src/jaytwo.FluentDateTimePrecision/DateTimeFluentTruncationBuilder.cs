using System;

namespace jaytwo.FluentDateTimePrecision
{
    public class DateTimeFluentTruncationBuilder : IDateTimeFluentTruncationBuilder
    {
        public DateTime Value { get; }

        public DateTimeFluentTruncationBuilder(DateTime value)
        {
            Value = value;
        }
    }
}
