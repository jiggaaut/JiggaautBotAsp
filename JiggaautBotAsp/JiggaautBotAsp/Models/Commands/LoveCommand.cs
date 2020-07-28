using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;

namespace JiggaautBotAsp.Models.Commands
{
    public class LoveCommand : Command
    {
        public override string Name => "love";

        public override void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            FileStream fs = System.IO.File.OpenRead("C:/Users/Jiggaaut/Desktop/pCpRt4b3-Jk.jpg");
            client.SendPhotoAsync(chatId, new InputOnlineFile(fs, "<3"));
        }
    }
}