using System;
using System.IO;
using System.Net.Sockets;

namespace SoundInvoker
{
    class SocketAPI
    {
        private readonly TcpClient client;
        private readonly StreamReader reader;
        private readonly StreamWriter writer;

        public SocketAPI(string url, int port)
        {
            client = new TcpClient(url, port);
            reader = new StreamReader(client.GetStream());
            writer = new StreamWriter(client.GetStream());
        }
        public void Disconect()
        {
            client.Close();
            reader.Dispose();
            writer.Dispose();
        }
        public bool Available() { return (client.Available > 0); }
        public void WriteLine(string line)
        {
            writer.WriteLine(line);
        }
        public void FlushWriter()
        {
            writer.Flush();
        }
        public string ReadLine()
        {
            return reader.ReadLine();
        }

    }
}
