using GC.Library.Database;
using GC.Library.Objects;
using GC.Library.Translators;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GC.Library.Routines
{
    internal static class AwaysActive
    {
        private static DateTime currentDate = DateTime.Now;

        internal static bool RunRoutine = false;
        //TODO ler announces a cada 15min  

        internal static async void Start(System.Windows.Forms.Panel pnlAdminMessages)
        {
            await Task.Run(() => Clock(pnlAdminMessages));
        }

        private static async void Clock(System.Windows.Forms.Panel pnlAdminMessages)
        {
            byte minutes = 0;

            DateTime nextMinute = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
            nextMinute.AddMinutes(1);

            int timeToWait = Convert.ToInt32(nextMinute.Subtract(DateTime.Now).TotalMilliseconds * -1);

            await Task.Delay(timeToWait);

            Task.Run(() => CheckAndSpeechReminders());

            while (RunRoutine)
            {
                if (!RunRoutine) break;

                await System.Threading.Tasks.Task.Delay(60000);
                //task.Wait();

                if (!RunRoutine) break;

                minutes += 1;

                //1 Minute tasks
                Task.Run(() => CheckAndSpeechReminders());

                //5 Minutes Tasks
                if (minutes == 5 || minutes == 10 || minutes == 15 || minutes == 20 || minutes == 25 || minutes == 30 ||
                    minutes == 35 || minutes == 40 || minutes == 45 || minutes == 50 || minutes == 55 || minutes == 60)
                {
                    Task.Run(() => CheckAndSpeechRequestsLate());
                }

                //10 Minutes Tasks
                if (minutes == 10 || minutes == 20 || minutes == 30 || minutes == 40 || minutes == 50 || minutes == 60)
                {
                    Task.Run(() => CheckActive());
                }

                //15 Minutes Tasks
                if (minutes == 15 || minutes == 30 || minutes == 45 || minutes == 60)
                {
                    Task.Run(() => CheckForAdminMessages(pnlAdminMessages));
                }

                //Half Hour Tasks
                if (minutes == 30 || minutes == 60)
                {
                    Task.Run(() => CheckPayment());
                }

                //Reseting minutes
                if (minutes == 60) minutes = 0;
            }
        }

        private static void CheckAndSpeechReminders()
        {
            if (currentDate.Day != DateTime.Now.Day && currentDate.Month != DateTime.Now.Month && currentDate.Year != DateTime.Now.Year) Reminder.UpdateTodaysReminders();

            foreach (int index in Reminder.TodaysRemindersIndices)
            {
                if (GlobalVariables.Reminders[index].Start.AddMinutes(-30).Hour == DateTime.Now.Hour &&
                   GlobalVariables.Reminders[index].Start.AddMinutes(-30).Minute == DateTime.Now.Minute)
                {
                    Sounds.Speech.AddSpeechToSpeakRow("Seu lembrete com o título, " + GlobalVariables.Reminders[index].Title + ", iniciará em 30 minutos.");
                }
                else if (GlobalVariables.Reminders[index].Start.AddMinutes(-15).Hour == DateTime.Now.Hour &&
                   GlobalVariables.Reminders[index].Start.AddMinutes(-15).Minute == DateTime.Now.Minute)
                {
                    Sounds.Speech.AddSpeechToSpeakRow("Seu lembrete com o título, " + GlobalVariables.Reminders[index].Title + ", iniciará em 15 minutos.");
                }
                else if (GlobalVariables.Reminders[index].Start.Hour == DateTime.Now.Hour &&
                   GlobalVariables.Reminders[index].Start.Minute == DateTime.Now.Minute)
                {
                    Sounds.Speech.AddSpeechToSpeakRow("Seu lembrete com o título, " + GlobalVariables.Reminders[index].Title + ", deve começar agora.");
                }
            }
        }

        private static void CheckForAdminMessages(System.Windows.Forms.Panel panel)
        {
            if (Database.MySqlReader.CheckForNewAdminMessages())
            {
                Errors.Care.HandleInvokeMethod(panel, new Action(() => {
                    panel.BackgroundImage = Properties.Resources.icon_new_message_30x30;
                }));
            }
        }

        private static void CheckPayment()
        {
            if (!Database.MySqlReader.CheckPayment())
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Seu periodo de testes acabou ou sua conta mensal não foi paga! Por isso, você não poderá mais usar o programa. Obrigado pela compreensão!", 2);
                messOk.Show();

                Auth.Token.ClearToken();
            }
        }

        private static void CheckActive()
        {
            if(!MySqlReader.CheckActive())
            {
                GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Seu programa foi forçado a ser fechado pela administração! Obrigado pela compreensão.", 2);
                messOk.Show();

                Auth.Token.ClearToken();
            }
        }

        private static void CheckAndSpeechRequestsLate()
        {
            bool hasLateReq = false;            

            var filtered = GlobalVariables.Requests.Where(x => !Checkers.Structs.IsDateTimeNull(x.ExpiresIn)).Select(x => x);
            foreach (Request item in filtered)
            {
                if (item.Status == 'A' || item.Status == 'F') continue;
                if (Checkers.Structs.IsDateTimeOlderOrSameThanNow(item.ExpiresIn))
                {
                    hasLateReq = true;

                    int index = GlobalVariables.Requests.FindIndex(x => x.Id == item.Id);
                    GlobalVariables.Requests[index].Status = 'A';

                    MySqlNonQuery.UpdateRequestStatus(item.Id, 'A');
                    Serialization.SerializeRequest(GlobalVariables.Requests[index]);
                }
            }

            if (GlobalVariables.OldRequests.Count > 0)
            {
                var filtered2 = GlobalVariables.OldRequests.Where(x => !Checkers.Structs.IsDateTimeNull(x.ExpiresIn)).Select(x => x);
                foreach (Request item2 in filtered2)
                {
                    if (item2.Status == 'A' || item2.Status == 'F') continue;
                    if (Checkers.Structs.IsDateTimeOlderOrSameThanNow(item2.ExpiresIn))
                    {
                        hasLateReq = true;

                        int index = GlobalVariables.OldRequests.FindIndex(x => x.Id == item2.Id);
                        GlobalVariables.OldRequests[index].Status = 'A';
                        Serialization.SerializeRequest(GlobalVariables.OldRequests[index]);
                    }
                }
            }

            if (hasLateReq)
            {
                if (GlobalVariables.Configuration.Enable_windows_voice_alerts)
                {
                    Sounds.Speech.AddSpeechToSpeakRow("Atenção, um ou mais pedidos acabaram de ficar atrasados, veja quais são em, Pedidos, na lista, Atrasados.");
                }

                if (GlobalVariables.Configuration.Enable_modal_alerts)
                {
                    GlobalModals.FRM_MessageAndOK messOk = new GlobalModals.FRM_MessageAndOK("Atenção! Um ou mais pedidos acabaram de ficar atrasados, veja quais são em, Pedidos, na lista, Atrasados.", 6);
                    messOk.Show();
                }
            }
        }
    }
}
