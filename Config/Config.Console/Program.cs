
using Config.Console;
using Config.Console.Provider;

var config = new Configuration
{
    CurrencyName = "RUB",
    LanguageName = "Ukr",
    PercentToSendNotifications = "241",
    SaveHistory = true,
    SendTelegramMessage = true,
    ShowHints = true,
    ShowSteamWalletBalance = true,
    TelegramToken = "132141411",
    ThemeName = "Dark",
    TimeToUpdate = "4",
    UseClipboard = true,
    SaveMarketDate = true,
    Message = "Hello world"

};

//Создаем класс для работы с сохранением и считыванием
ConfigProvider provider = new("cfg.txt", config);

//Считываем инфу
var newCfg = provider.ReadHandler.Read();



Console.ReadLine();
