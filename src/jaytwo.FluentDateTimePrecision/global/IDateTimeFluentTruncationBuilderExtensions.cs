using jaytwo.FluentDateTimePrecision;
using System;

public static class IDateTimeFluentTruncationBuilderExtensions
{
    public static IDateTimeFluentTruncationBuilder Truncate(this DateTime value)
    {
        return new DateTimeFluentTruncationBuilder(value);
    }

    public static DateTime ToSecond(this IDateTimeFluentTruncationBuilder builder)
    {
        var value = builder.Value;
        return new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second, value.Kind);
    }

    public static DateTime ToMinute(this IDateTimeFluentTruncationBuilder builder)
    {
        var value = builder.Value;
        return new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, 0, value.Kind);
    }

    public static DateTime Day(this IDateTimeFluentTruncationBuilder builder)
    {
        var value = builder.Value;
        return new DateTime(value.Year, value.Month, value.Day, 0, 0, 0, value.Kind);
    }
}
