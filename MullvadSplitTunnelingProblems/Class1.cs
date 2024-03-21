using System.Net;
using System.Net.Sockets;

namespace MullvadSplitTunnelingProblems
{
    public class Class1
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient();

            //Test against any IPV4 IP that hosts a TCP socket server of any kind - can be a Terraria server, but you can probably use any TCP echo server as long as it's listening on a v4 IP.

            Console.WriteLine($"Input a IPV4 TCP server IP.");
            client.Connect(new IPEndPoint(IPAddress.Parse(Console.ReadLine()), 7777));

            Console.ReadLine();
        }
    }
}
