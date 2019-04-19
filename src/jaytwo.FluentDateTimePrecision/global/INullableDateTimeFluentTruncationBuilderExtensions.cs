using jaytwo.FluentDateTimePrecision;
using System;

public static class INullableDateTimeFluentTruncationBuilderExtensions
{
    public static INullableDateTimeFluentTruncationBuilder Truncate(this DateTime? value)
    {
        return new NullableDateTimeFluentTruncationBuilder(value);
    }

    public static DateTime? ToSecond(this INullableDateTimeFluentTruncationBuilder builder)
    {
        if (builder?.Value == null)
        {
            return null;
        }

        var value = builder.Value.Value;
        return new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second, value.Kind);
    }

    public static DateTime? ToMinute(this INullableDateTimeFluentTruncationBuilder builder)
    {
        if (builder?.Value == null)
        {
            return null;
        }

        var value = builder.Value.Value;
        return new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, 0, value.Kind);
    }

    public static DateTime? Day(this INullableDateTimeFluentTruncationBuilder builder)
    {
        if (builder?.Value == null)
        {
            return null;
        }

        var value = builder.Value.Value;
        return new DateTime(value.Year, value.Month, value.Day, 0, 0, 0, value.Kind);
    }
}