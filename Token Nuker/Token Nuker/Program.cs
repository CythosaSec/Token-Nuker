using Discord.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Token_Nuker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("  token > ");
            string token = Console.ReadLine();

            DiscordSocketClient client = new DiscordSocketClient();
            client.Login(token);

            client.OnLoggedIn += Client_OnLoggedIn;

            Thread.Sleep(-1);
        }

        private static void Client_OnLoggedIn(DiscordSocketClient client, LoginEventArgs args)
        {

        }
    }
}
