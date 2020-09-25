using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace MyLobbyAD.Services
{
    public class ShedulerService
    {
        private static Timer timer;
        public static DateTime PreviousUpdate { get; set; }
        public static bool Enabled { get; set; }
        public static Dictionary<string, int> timeItems = new Dictionary<string, int>() {
            {"3 hours", 1080000},
            {"6 hours", 2160000},
            {"12 hours", 4320000},
            {"day", 8640000},
            {"week", 60480000},
            {"two weeks", 120960000},
            {"month", 259200000}
        };
        public static void SetTime(string key)
        {
            Timer timer = new Timer(timeItems[key]);
            timer.Elapsed += async (sender, e) => await ApiService.UploadUsers();
            if (Enabled)
            {
                Start();
            }
            else
            {
                Stop();
            }
        }
        public static void SetDefault()
        {
            Timer timer = new Timer(1080000);
            timer.Elapsed += async (sender, e) => await ApiService.UploadUsers();
        }
        public static void Start()
        {
            if (Enabled)
            {
                if (timer == null)
                {
                    SetDefault();
                }
                timer.Start();
                PreviousUpdate = DateTime.Now;
            }
        }
        public static void Stop()
        {
            timer.Stop();
        }
    }
}
