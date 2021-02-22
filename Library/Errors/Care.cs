using GC.Components;
using System;
using System.IO;
using System.Windows.Forms;

namespace GC.Library.Errors
{
    internal static class Care
    {
        internal static bool AntiInvalidInstance = true;

        internal static void AppendOnErrorLogFile(string exceptionMessage)
        {
            StreamWriter sw = File.AppendText(Informations.Directories.ErrorsLogs);
            sw.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " -> " + exceptionMessage);
            sw.Close();
        }

        internal static void HandleInvokeMethod(ref Panel pnl, Action act)
        {
            if (pnl.InvokeRequired)
            {
                pnl.Invoke(act);
            }
            else
            {
                try
                {
                    act.Invoke();
                }
                catch (InvalidOperationException)
                {
                    pnl.Invoke(act);
                }
            }
        }

        internal static void HandleInvokeMethod(ref CMP_CtlPanel pnl, Action act)
        {
            try
            {
                if (pnl.InvokeRequired)
                {
                    pnl.Invoke(act);
                }
                else
                {
                    try
                    {
                        act.Invoke();
                    }
                    catch (InvalidOperationException)
                    {
                        pnl.Invoke(act);
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        internal static void HandleInvokeMethod(ref WebBrowser wbs, Action act)
        {
            if (wbs.InvokeRequired)
            {
                wbs.Invoke(act);
            }
            else
            {
                try
                {
                    act.Invoke();
                }
                catch (InvalidOperationException)
                {
                    wbs.Invoke(act);
                }
            }
        }

        internal static void HandleInvokeMethod(Panel pnl, Action act)
        {
            if (pnl.InvokeRequired)
            {
                pnl.Invoke(act);
            }
            else
            {
                try
                {
                    act.Invoke();
                }
                catch (InvalidOperationException)
                {
                    pnl.Invoke(act);
                }
            }
        }

        internal static void HandleInvokeMethod(Form form, Action act)
        {
            if (form.InvokeRequired)
            {
                form.Invoke(act);
            }
            else
            {
                try
                {
                    act.Invoke();
                }
                catch (InvalidOperationException)
                {
                    form.Invoke(act);
                }
            }
        }
    }
}
