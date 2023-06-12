using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Sigida.ConsoleServer
{
    public class ServerObject
    {
        static TcpListener tcpListener;
        List<ClientObject> _clients = new();

        public void AddConnection(ClientObject clientObject)
        {
            _clients.Add(clientObject);
        }

        internal void BrodcastMessage(string message, string id)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);

            for (int i = 0; i < _clients.Count; i++)
            {
                if (_clients[i].Id != id)
                {
                    _clients[i].Stream.Write(data,0,data.Length);
                }
            }
        }

        protected internal void Listen()
        {
            try
            {
                tcpListener = new(IPAddress.Any, 8888);
                tcpListener.Start();
                Console.WriteLine("Сервер зпущен. Ожидаем подключений");

                while (true)
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();

                    ClientObject clientObject = new(tcpClient, this);
                    Thread clientThread = new(new ThreadStart(clientObject.Procrss));
                    clientThread.Start();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Disconnect();
            }
        }

        internal void RemoveConnection(string id)
        {
            ClientObject client = _clients.FirstOrDefault(c => c.Id == id);

            if (client != null)
                _clients.Remove(client);
        }

        protected internal void Disconnect()
        {
            tcpListener.Stop();

            for (int i = 0; i < _clients.Count; i++)
            {
                _clients[i].Close();
            }
            Environment.Exit(0);
        }
    }
}