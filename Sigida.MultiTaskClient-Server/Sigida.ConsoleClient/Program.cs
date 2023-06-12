
using System.Net.Sockets;
using System.Text;

int port = 8888;
string address = "127.0.0.1";
string username = null;

TcpClient client = null;
NetworkStream stream;

Console.WriteLine("Введите свое имя: ");
username = Console.ReadLine();

client = new();

try
{
    client.Connect(address, port);
    stream = client.GetStream();

    string message = username;
    byte[] data = Encoding.Unicode.GetBytes(message);
    stream.Write(data,0,data.Length);

    Thread recieveThread = new(new ParameterizedThreadStart(ReceiveMessage));
    recieveThread.Start(stream);
    Console.WriteLine($"Добро пожаловать {username}");
    SendMessage(stream);
}
catch (Exception ex)
{
    throw;
}
finally
{
    client.Close();
}

static void SendMessage(NetworkStream stream)
{
    Console.WriteLine("Введите сообщение: ");

    while (true)
    {
        string message = Console.ReadLine();
        byte[] data = Encoding.Unicode.GetBytes(message);
        stream.Write(data, 0, data.Length);
    }
}
// получение сообщений
static void ReceiveMessage(object stream)
{
    stream = ((NetworkStream)stream);
    while (true)
    {
        try
        {
            byte[] data = new byte[64]; // буфер для получаемых данных
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (stream.DataAvailable);

            string message = builder.ToString();
            Console.WriteLine(message);//вывод сообщения
        }
        catch
        {
            Console.WriteLine("Подключение прервано!"); //соединение было прервано
            Console.ReadLine();
            Disconnect();
        }
    }
}

static void Disconnect()
{
    if (stream!=null)
        stream.Close();//отключение потока
    if (client!=null)
        client.Close();//отключение клиента
    Environment.Exit(0); //завершение процесса
}