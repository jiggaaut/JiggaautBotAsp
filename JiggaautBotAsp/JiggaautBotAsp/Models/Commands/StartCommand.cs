using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace JiggaautBotAsp.Models.Commands
{
    public class StartCommand : Command
    {
        public override string Name => "hello";

        public override void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //

            client.SendTextMessageAsync(chatId, "Приветики", replyToMessageId: messageId);
        }
    }
}