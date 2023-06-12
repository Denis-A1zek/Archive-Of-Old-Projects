using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.ConsoleServer
{
    public class ClientObject
    {

        private string _username;
        private TcpClient _client;
        private ServerObject _server;
        public ClientObject(TcpClient client, ServerObject server)
        {
            Id = Guid.NewGuid().ToString();
            _client = client;
            _server = server;
            _server.AddConnection(this);
        }
        protected internal string Id { get; private set; }
        protected internal NetworkStream Stream { get; private set; }
        
        public void Procrss()
        {
            NetworkStream stream = null;

            try
            {
                Stream = _client.GetStream();
                string message = GetMessage();
                _username = message;

                message = $"{_username} вошел в чат";

                _server.BrodcastMessage(message, this.Id);
                Console.WriteLine(message);
                
                while(true)
                {
                    try
                    {
                        message = GetMessage();
                        message = $"{_username}: {message}";
                        Console.WriteLine(message);
                        _server.BrodcastMessage(message, this.Id);
                    }
                    catch
                    {
                        message = $"{_username} left from chat";
                        Console.WriteLine(message);
                        _server.BrodcastMessage(message, this.Id);
                        break;
                    }                 
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _server.RemoveConnection(this.Id);
                Close();
            }
        }

        private string GetMessage()
        {
            byte[] data = new byte[64];
            StringBuilder builder = new();

            int bytes = 0;

            do
            {
                bytes = Stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (Stream.DataAvailable);

            return builder.ToString();
        }

        protected internal void Close()
        {
            if (Stream != null)
                Stream.Close();
            if (client != null)
                client.Close();
        }

    }
}
