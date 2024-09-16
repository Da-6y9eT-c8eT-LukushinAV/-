namespace Singleton_Pat
{
    class Program
    {
        static void Main()
        {
            var servers = Servers.Instance;

            servers.AddServer("http://example.com");
            servers.AddServer("https://secure.com");
            servers.AddServer("http://another.com");

            Console.WriteLine("HTTP Servers:");
            foreach (var server in servers.GetHttpServers())
            {
                Console.WriteLine(server);
            }

            Console.WriteLine("HTTPS Servers:");
            foreach (var server in servers.GetHttpsServers())
            {
                Console.WriteLine(server);
            }
        }
    }
}
