using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pat
{
    public class Servers
    {
        ///Задание 1


        private static Servers instance = null;

        private Servers()
        {
            serverList = new List<string>();
        }

        public static Servers Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Servers();
                }
                return instance;
            }
        }
        private List<string> serverList;

        public bool AddServer(string server)
        {
            if ((server.StartsWith("http://") || server.StartsWith("https://")) && !serverList.Contains(server))
            {
                serverList.Add(server);
                return true; 
            }
            return false; 
        }

        public List<string> GetHttpServers()
        {
            return serverList.Where(s => s.StartsWith("http://")).ToList();
        }

        public List<string> GetHttpsServers()
        {
            return serverList.Where(s => s.StartsWith("https://")).ToList();
        }






        ///Задание 2 ЛЕНИВЫЙ с потоком

        //private static Servers instance;


        //private static readonly object lockObject = new object();


        //public static Servers Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            lock (lockObject)
        //            {
        //                if (instance == null)
        //                {
        //                    instance = new Servers();
        //                }
        //            }
        //        }
        //        return instance;
        //    }
        //}
        //private Servers()
        //{
        //    serverList = new List<string>();
        //}

        //private List<string> serverList;

        //public bool AddServer(string server)
        //{
        //    lock (lockObject)
        //    {
        //        if ((server.StartsWith("http://") || server.StartsWith("https://")) && !serverList.Contains(server))
        //        {
        //            serverList.Add(server);
        //            return true;
        //        }
        //        return false;
        //    }
        //}

        //public List<string> GetHttpServers()
        //{
        //    lock (lockObject)
        //    {
        //        return serverList.Where(s => s.StartsWith("http://")).ToList();
        //    }
        //}

        //public List<string> GetHttpsServers()
        //{
        //    lock (lockObject)
        //    {
        //        return serverList.Where(s => s.StartsWith("https://")).ToList();
        //    }
        //}




        /// ЗАДАНИЕ 3 ЖАДНЫЙ

        //private static readonly Servers instance = new Servers();

        //public static Servers Instance => instance;

        //private Servers()
        //{
        //    serverList = new List<string>();
        //}

        //private List<string> serverList;

        //public bool AddServer(string server)
        //{
        //    if ((server.StartsWith("http://") || server.StartsWith("https://")) && !serverList.Contains(server))
        //    {
        //        serverList.Add(server);
        //        return true;
        //    }
        //    return false;
        //}

        //public List<string> GetHttpServers()
        //{
        //    return serverList.Where(s => s.StartsWith("http://")).ToList();
        //}

        //public List<string> GetHttpsServers()
        //{
        //    return serverList.Where(s => s.StartsWith("https://")).ToList();
        //}

    }
}

