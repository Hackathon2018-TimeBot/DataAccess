using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace ConsoleTestapplication
{
    public static class SetupClient
    {
        public static void ConfigureHttpClient(ref HttpClient Client, string BaseAdress)
        {
            Client.BaseAddress = new Uri(BaseAdress);
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
