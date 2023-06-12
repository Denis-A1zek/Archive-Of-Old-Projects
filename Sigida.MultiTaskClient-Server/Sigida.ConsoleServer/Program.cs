
using Sigida.ConsoleServer;
using System.Net;
using System.Net.Sockets;

ServerObject server = null;
Thread listenThread;

try
{
    server = new ServerObject();
    listenThread = new Thread(new ThreadStart(server.Listen));
    listenThread.Start();
}
catch(Exception ex)
{
    server.Disconnect();
    Console.WriteLine(ex.Message);
}
finally
{

}