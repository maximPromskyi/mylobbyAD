using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyLobbyAD.Services
{
    public class SchedulerService
    {
        private static Timer timer;
        public static DateTime PreviousUpdate { get; set; }
        public static DateTime NextUpdate { get; set; }
        public static TimeSpan Interval { get; set; }
        public static ActiveDirectoryForm activeDirectoryForm;
        public static SchedulerForm schedulerForm;
        public static bool Enabled { get; private set; }
        public static string Key { get; private set; } = "3 hours";
        private static TimerCallback tm = new TimerCallback(SetInterval);
        private static readonly int period = 1000;
        public static Dictionary<string, long> timeItems = new Dictionary<string, long>() {
            {"10 second", 10000},
            {"3 hours", 10800000},
            {"6 hours", 21600000},
            {"12 hours", 43200000},
            {"day", 86400000},
            {"week", 604800000},
            {"two weeks", 1209600000},
            {"month", 2592000000}
        };
        public static void SetADForm(ActiveDirectoryForm form)
        {
            if (activeDirectoryForm != null)
            {
                activeDirectoryForm.Close();
            }
            activeDirectoryForm = form;
        }
        public static void SetSchedulerForm(SchedulerForm form)
        {
            if (schedulerForm != null)
            {
                schedulerForm.Close();
            }
            schedulerForm = form;
        }
        public static void SetTime()
        {
            UpdateInterval();
            if (timer == null)
            {
                timer = new Timer(tm, 1, 0, period);
            }
            else
            {
                timer.Change(0, period);
            }

        }
        public static void SetTimerInfo()
        {
            string dateInfo = $"Time to update: {SchedulerService.ConvertStrInterval()}";
            if (activeDirectoryForm != null)
            {
                activeDirectoryForm.Invoke(new Action(
                    () => activeDirectoryForm.timerInfo.Text = dateInfo));
            }
            if (schedulerForm != null)
            {
                schedulerForm.Invoke(new Action(
                    () => schedulerForm.timerInfo.Text = dateInfo));
            }
        }
        private static void UpdateInterval()
        {
            PreviousUpdate = DateTime.UtcNow;
            NextUpdate = PreviousUpdate.AddMilliseconds(timeItems[Key]);
            Interval = NextUpdate - PreviousUpdate;
        }
        private static async void SetInterval(object seconds)
        {
            Interval = NextUpdate - DateTime.UtcNow;
            if (Interval.TotalSeconds <= 0)
            {
                activeDirectoryForm.Invoke(new Action(
                    () => activeDirectoryForm.StartLoader()));

                timer.Change(Timeout.Infinite, Timeout.Infinite);
                // await ApiService.UploadUsers();
                activeDirectoryForm.Invoke(new Action(
                    () => activeDirectoryForm.Success()));
                UpdateInterval();
                timer = new Timer(tm, 1, 0, period);

                activeDirectoryForm.Invoke(new Action(
                    () => activeDirectoryForm.StopLoader()));
            }
            SetTimerInfo();
        }
        public static void Start(string key = "3 hours")
        {
            Key = key;
            SetTime();
            Enabled = true;
        }
        public static string ConvertStrInterval()
        {
            string days = Interval.Days == 0
                ? "" : $"{Interval.Days} day";
            days += Interval.Days > 1 ? "s" : "";

            string hours = Interval.Hours > 9
                ? Interval.Hours.ToString() 
                : $"0{Interval.Hours}";

            string minutes = Interval.Minutes > 9
                ? Interval.Minutes.ToString()
                : $"0{Interval.Minutes}";
            return $"{days} {hours}:{minutes}:{Interval.Seconds.ToString()}";
        }
        public static void Stop()
        {
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            Enabled = false;
        }
        public static void AddToAutoStart()
        {
            const string applicationName = "MyLobbyAD";
            const string pathRegistryKeyStartup =
                        "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

            using (RegistryKey registryKeyStartup =
                        Registry.CurrentUser.OpenSubKey(pathRegistryKeyStartup, true))
            {
                registryKeyStartup.SetValue(
                    applicationName,
                    string.Format("\"{0}\"", System.Reflection.Assembly.GetExecutingAssembly().Location));
            }
        }
    }
}
