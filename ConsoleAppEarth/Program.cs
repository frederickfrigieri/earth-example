using System;
using System.Net.Http;

namespace ConsoleAppEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            var endpoint = "get_listings";
            var client = new HttpClientCustom();
            var data = client.GetExample<Root>(endpoint);
        }
    }
}
