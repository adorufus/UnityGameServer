using System;

namespace GameServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My Game Server";
            Server.Start(50, 6257);
            Console.ReadKey();
        }
    }
}
