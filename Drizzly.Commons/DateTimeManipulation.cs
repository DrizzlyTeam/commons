using System;

namespace Drizzly.Commons
{
    public static class DateTimeManipulation
    {
        public static DateTime TimestampToDateTime(this double unixTimeStamp)
        {
            
            DateTime datetime = new DateTime(1970,1,1,0,0,0,0, DateTimeKind.Utc);
            datetime = datetime.AddSeconds(unixTimeStamp).ToLocalTime();
            
            return datetime;
            
        }

        public static double DateTimeToTimestamp(DateTime datetime)
        {
            return ((DateTimeOffset) datetime).ToUnixTimeSeconds();
        }

    }
}