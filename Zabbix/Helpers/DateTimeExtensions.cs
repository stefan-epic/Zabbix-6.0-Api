namespace ZabbixApi.Helper;

internal static class DateTimeExtensions
{
    public static long ToTimestamp(this DateTime dateTime)
    {
        return (long)dateTime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc))
            .TotalSeconds;
    }

    public static DateTime AsTimestampToDateTime(this long timestamp)
    {
        return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestamp).ToLocalTime();
    }

    public static DateTime AsTimestampToDateTime(this int timestamp)
    {
        return ((long)timestamp).AsTimestampToDateTime();
    }

    public static DateTime AsTimestampToDateTime(this float timestamp)
    {
        return ((long)timestamp).AsTimestampToDateTime();
    }

    public static DateTime AsTimestampToDateTime(this double timestamp)
    {
        return ((long)timestamp).AsTimestampToDateTime();
    }
}