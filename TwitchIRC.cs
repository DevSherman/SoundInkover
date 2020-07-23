using System;
using System.Timers;

namespace SoundInvoker
{
    public class TwitchIRC
    {
        private readonly SocketAPI socket;
        private readonly string CHANNEL_NAME;
        private readonly string OAUTH_TOKEN;

        public event EventHandler DataAvailable;

        private string currentData;
        private Timer timer;

        public void StopThread()
        {
            timer.Stop();
        }

        public TwitchIRC(string CHANNEL_NAME, string OAUTH_TOKEN)
        {
            this.CHANNEL_NAME = CHANNEL_NAME;
            this.OAUTH_TOKEN = OAUTH_TOKEN;

            socket = new SocketAPI("irc.chat.twitch.tv", 6667);
            Connect();
        }

        private void Connect()
        {
            socket.WriteLine("PASS " + OAUTH_TOKEN);
            socket.WriteLine("NICK " + CHANNEL_NAME);
            socket.WriteLine("USER " + CHANNEL_NAME + " 8 * :" + CHANNEL_NAME);
            socket.WriteLine("JOIN #" + CHANNEL_NAME);
            socket.FlushWriter();

            timer = new Timer(100);
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        public void Disconnect()
        {
            timer.Stop();
            socket.Disconect();
        }

        public string GetData()
        {
            return currentData;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (socket.Available())
            {
                currentData = Read();
                if (currentData != null) DataAvailable.Invoke(currentData, null);
            }
        }

        private string Read()
        {
            var result = socket.ReadLine();

            if (result.Contains("PRIVMSG"))
            {
                int intIndexParseSign = result.IndexOf('!');
                //string userName = result.Substring(1, intIndexParseSign - 1);
                intIndexParseSign = result.IndexOf(" :");
                return result.Substring(intIndexParseSign + 2);
            }
            return result;
        }
        public void SendIRC(string message)
        {
            try
            {
                socket.WriteLine(message);
                socket.FlushWriter();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void SendMessage(string message)
        {
            try
            {
                SendIRC(":" + CHANNEL_NAME + "!" + CHANNEL_NAME + "@" + CHANNEL_NAME +
                        ".tmi.twitch.tv PRIVMSG #" + CHANNEL_NAME + " :" + message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}