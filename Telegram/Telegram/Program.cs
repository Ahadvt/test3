using System.Net;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.IO;




TelegramBotClient Bot = new TelegramBotClient("xxxxxx");

 void Form1_Load(object sender, EventArgs e)
{
    Bot.StartReceiving();
    Bot.OnMessage += Bot_OnMessage;
}


