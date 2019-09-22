using System;
using System.Globalization;

namespace StockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkingWithTimeZone();
            WorkingWithDateTimeOffset();
            WorkingWithISO8601();

            // Converting string to DateTime or DateTimeOffset
            var date = "9/10/2019 10:00:00 PM";
            var parsedDate1 = DateTime.ParseExact(date, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
            Console.WriteLine(parsedDate1);

            var date2 = "9/10/2019 10:00:00 PM +02:00";
            var parsedDate2 = DateTime.Parse(date2, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
            Console.WriteLine(parsedDate2);
            Console.WriteLine(parsedDate2.Kind); //Local/UTC

            WorkingWithDateTimeArithmetic();
            WorkingWithCalendar();

            // Extending Contracts
            var contractDate = new DateTimeOffset(2019, 7, 1, 0, 0, 0, TimeSpan.Zero);
            Console.WriteLine(contractDate);

            contractDate = contractDate.AddMonths(6).AddTicks(-1);
            Console.WriteLine(contractDate);
        }

        private static void WorkingWithTimeZone()
        {
            // It will give us a "Local" version of time in this machine.
            var now = DateTime.Now;

            // Getting TimeZoneInfo
            // NOTE: It depends on the OS is running at local machine.
            TimeZoneInfo sydneyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");
            var sydneyTime = TimeZoneInfo.ConvertTime(now, sydneyTimeZone);

            // Now, We have local time and Sydney time. It's recommendable to work with UTC (Universal Time Coordinated).
            Console.WriteLine(now);
            Console.WriteLine(sydneyTime);
        }

        private static void WorkingWithDateTimeOffset()
        {
            var time = DateTimeOffset.Now.ToOffset(TimeSpan.FromHours(5));

            foreach(var timeZone  in TimeZoneInfo.GetSystemTimeZones())
            {
                if(timeZone.GetUtcOffset(time) == time.Offset)
                {
                    Console.WriteLine(timeZone);
                }
            }

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTimeOffset.Now);
        }

        private static void WorkingWithISO8601()
        {
            // ISO-8601 Format --> 2019-06-10T18:00:00+00:00
            // Year: 2019
            // Month: 06
            // Day: 10
            // Time dilimiter: T
            // Hour: 18
            // Minute: 00
            // Second: 00
            // Time zone offset or Zulu time (Z): +00:00
            var date = "9/10/2019 10:00:00 PM";
            var parsedDate3 = DateTimeOffset.ParseExact(date, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
            Console.WriteLine(parsedDate3.ToString("s"));

            parsedDate3 = parsedDate3.ToOffset(TimeSpan.FromHours(10));
            Console.WriteLine(parsedDate3.ToString("o"));

            // UTC
            var utcDateTime = DateTimeOffset.UtcNow;
            Console.WriteLine(utcDateTime.ToLocalTime());
            Console.WriteLine(utcDateTime.ToUniversalTime());
        }

        private static void WorkingWithDateTimeArithmetic()
        {
            // TimeSpan (Ticks: Nanoseconds)
            // It represents a time interval (1 day 23 hours 0 minutes)
            var timeSpan = new TimeSpan(60, 100, 200);
            var timeSpanBroadCastTime = new TimeSpan(6, 0, 0);

            Console.WriteLine(timeSpan.Days);       // 2
            Console.WriteLine(timeSpan.Hours);      // 13
            Console.WriteLine(timeSpan.Minutes);    // 43
            Console.WriteLine(timeSpan.Seconds);    // 20

            var start = DateTimeOffset.UtcNow;
            var end = start.AddSeconds(45);

            TimeSpan difference = end - start;

            Console.WriteLine(difference.Seconds);
        }
    
        private static void WorkingWithCalendar()
        {
            Calendar calendar = CultureInfo.InvariantCulture.Calendar;
            var start = new DateTimeOffset(2007, 12, 31, 0, 0, 0, TimeSpan.Zero);
            var week = calendar.GetWeekOfYear(start.DateTime, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            Console.WriteLine(week);
            Console.WriteLine(GetIso8601WeekOfYear(start.DateTime));

            // Only available in .Net Core v3
            //var isoWeek = ISOWeek.GetWeekOfYear(start.DateTime);
            //Console.WriteLine(weisoWeekek);
        }

        public static int GetIso8601WeekOfYear(DateTime time)
        {
            Calendar calendar = CultureInfo.InvariantCulture.Calendar;
            DayOfWeek day = calendar.GetDayOfWeek(time);

            if(day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            return calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}