using JiggaautBotAsp.Models.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Telegram.Bot;

namespace JiggaautBotAsp.Models
{
    public static class Bot
    {
        private static TelegramBotClient client;
        private static List<Command> commandsList;

        public static IReadOnlyList<Command> Commands { get => commandsList.AsReadOnly(); }

        public static async Task<TelegramBotClient> Get()
        {
            if (client != null)
            {
                return client;
            }

            commandsList = new List<Command>();
            commandsList.Add(new StartCommand());
            commandsList.Add(new LoveCommand());
            commandsList.Add(new FitCommand());
            //

            client = new TelegramBotClient(AppSettings.Key);
            var hook = string.Format(AppSettings.URL, "api/message/update");
            await client.SetWebhookAsync(hook);
            return client;
        }
    }
}