using System;
using System.Net.Http;

namespace ConsoleTestapplication
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Base-URI");
            string baseUri = Console.ReadLine();

            //Prepare Client
            SetupClient.ConfigureHttpClient(ref client, baseUri);

            //RunTests
            //RunTests();

            //Insert Demo Data
            InsertData();

            //Delete Demo Data
            DeleteData();
        }


        private static void RunTests()
        {
            Tests.ContractTest.RunTest(client);
            Tests.CustomerTest.RunTest(client);
            Tests.LocationTest.RunTest(client);
            Tests.PersonTest.RunTest(client);
            Tests.ProjectTest.RunTest(client);
            Tests.ResourceTest.RunTest(client);
        }

        private static void InsertData()
        {
            Demo.DemoData.AddData(client);
        }

        private static void DeleteData()
        {
            Demo.DemoData.DeleteData(client);
        }
    }
}
