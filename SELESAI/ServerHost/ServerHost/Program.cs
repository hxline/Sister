using System;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;

namespace ServerHost
{
    class Program
    {
        static void Main(string[] args)
        {
            string url;
            Console.Write("IP dan Port yang digunakan : ");
            url = "http://" + Console.ReadLine();
            
            using (WebApp.Start(url))
            {
                Console.WriteLine("Server berjalan di IP {0}", url);
                Console.ReadLine();
            }
        }
    }




}
