using System;
using Newtonsoft.Json.Linq;

namespace GC.Library.Checkers
{
    internal static class Structs
    {
        /// <summary>
        /// Checks if the windows's clock is in a range of 2 minutes later or 2 minutes after the web time.
        /// </summary>
        /// <returns>If there's an error when trying to read the web time returns -1, if system time is out of the range returns 0 or returns 1 if the system clock is in the range</returns>
        internal static int IsSystemAndWebDateTimeSync()
        {
            DateTime networkDateTime = new DateTime(1, 1, 1);

            try
            {
                JObject parsedObject = JObject.Parse(Web.HttpRequest.Get("http://worldtimeapi.org/api/timezone/America/Sao_Paulo"));

                networkDateTime = DateTime.ParseExact(parsedObject.Value<string>("datetime"), "MM/dd/yyyy HH:mm:ss", null);               
            }
            catch(Exception)
            {
                try
                {
                    JObject parsedObject2 = JObject.Parse(Web.HttpRequest.Get("http://api.timezonedb.com/v2.1/get-time-zone?key=V815XCRF0793&format=json&by=zone&zone=America/Sao_Paulo"));

                    if (parsedObject2.Value<string>("status") != "OK") throw new Exception();
                    else
                    {
                        bool result = DateTime.TryParse(parsedObject2.Value<string>("formatted"), out networkDateTime);
                        if (!result)
                        {
                            throw new Exception();
                        }
                    }
                }
                catch(Exception)
                {
                    return -1;
                }
            }

            //To prevent the null value
            if (networkDateTime.Day == 1 && networkDateTime.Month == 1 && networkDateTime.Year == 1) return -1;
            
            //Checking the range
            if (DateTime.Compare(networkDateTime.AddMinutes(-2), DateTime.Now) == -1 &&
                DateTime.Compare(networkDateTime.AddMinutes(2), DateTime.Now) == 1) return 1;
            else return 0;
        }

        /// <summary>
        /// Returns true if the DateTime entered is null.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        internal static bool IsDateTimeNull(DateTime dateTime)
        {
            DateTime nullDateTime = new DateTime(1, 1, 1, 0, 0, 0);
            if (DateTime.Compare(dateTime, nullDateTime) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool IsDateTimeOlderOrSameThanNow(DateTime dateTime)
        {
            if (DateTime.Compare(dateTime, DateTime.Now) <= 0)
            {
                return true;
            }
            else return false;
        }
        internal static bool IsDateOlderOrEqualsToDate(DateTime d1, DateTime d2)
        {
            if (DateTime.Compare(d1, d2) <= 0)
            {
                return true;
            }
            else return false;
        }

        internal static bool IsDateNewerOrEqualsThanDate(DateTime d1, DateTime d2)
        {
            if (DateTime.Compare(d1, d2) <= 0)
            {
                return false;
            }
            else return true;
        }

        internal static bool IsDateSameThanToday(DateTime date)
        {
            if (date.Year == DateTime.Now.Year && date.Month == DateTime.Now.Month && date.Day == DateTime.Now.Day) return true;
            else return false;
        }

        internal static bool IsDateSameThanYesterday(DateTime date)
        {
            DateTime yesterday = DateTime.Now.AddDays(-1);

            if (date.Year == yesterday.Year && date.Month == yesterday.Month && date.Day == yesterday.Day) return true;
            else return false;
        }

        internal static bool IsSingleDateEqualsToSingleDate(DateTime d1, DateTime d2)
        {
            if (d1.Year == d2.Year && d1.Month == d2.Month && d1.Day == d2.Day) return true;
            else return false;
        }
    }
}
