using GC.Library.Database;
using GC.Library.Objects;
using System;
using System.Collections.Generic;

namespace GC.Library.Routines
{
    internal static class Fortnight
    {
        internal static void Start()
        {
            if (Checkers.Structs.IsDateTimeNull(GlobalVariables.Configuration.Last_routine_operations_fortnight) || !Checkers.Structs.IsDateNewerOrEqualsThanDate(GlobalVariables.Configuration.Last_routine_operations_fortnight, DateTime.Now.AddDays(-15)))
            {
                // Cancelled Requests Delete
                if (GlobalVariables.Configuration.Auto_clear_cancelled_req)
                {
                    Files.SeekFor.CancelledRequests();

                    List<string> deleted = new List<string>();

                    foreach (Request item in GlobalVariables.CancelledRequests)
                    {
                        if (!Checkers.Structs.IsDateNewerOrEqualsThanDate(item.StartedIn, DateTime.Now.AddDays(-180)))
                        {
                            Files.Control.DeleteRequestFile(item.Number);

                            deleted.Add(item.Number);
                        }
                    }
                    foreach (string number in deleted)
                    {
                        GlobalVariables.CancelledRequests.RemoveAll(x => x.Number == number);
                    }
                }

                GlobalVariables.Configuration.Last_routine_operations_fortnight = DateTime.Now;

                MySqlNonQuery.UpdateLastFortnight();
            }
        }
    }
}
