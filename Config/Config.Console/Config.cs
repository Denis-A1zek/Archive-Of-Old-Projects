using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config.Console
{
    public class Configuration
    {
        public bool ShowHints { get; set; }
        public bool ShowSteamWalletBalance { get; set; }
        public bool SendTelegramMessage { get; set; }
        public string TelegramToken { get; set; }
        public string PercentToSendNotifications { get; set; }
        public string TimeToUpdate { get; set; }
        public string CurrencyName { get; set; }
        public string LanguageName { get; set; }
        public string ThemeName { get; set; }
        public bool UseClipboard { get; set; }
        public bool SaveHistory { get; set; }
        public bool SaveMarketDate { get; set; }
        public string Message { get; set; }

    }
}
