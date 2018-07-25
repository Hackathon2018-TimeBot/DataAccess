using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Timekeeper.Models.DataModels;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ConsoleTestapplication.Tests
{
    public static class LocationTest
    {
        internal static void RunTest(HttpClient client)
        {
            List<Location> demoData = GetDemoData();

            //Mass insert
            //InsertItems(demoData, client);

            //Mass read
            //GetItems(demoData, client);

            //Mass update
            //UpdateItems(demoData, client);

            //Mass delete
            //DeleteItems(demoData, client);
        }

        

        private static void GetItems(List<Location> demoData, HttpClient client)
        {
            try
            {
                List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();

                foreach (var item in demoData)
                {
                    tasks.Add(client.GetAsync("api/Location/" + item.ID.ToString()));
                }

                Task.WaitAll(tasks.ToArray());

                List<Task<Location>> readContracts = new List<Task<Location>>();
                foreach (Task<HttpResponseMessage> t in tasks)
                {
                    if (t.IsCompletedSuccessfully)
                    {
                        readContracts.Add(t.Result.Content.ReadAsAsync<Location>());
                        //Done
                    }
                    else
                    {
                        //Error
                    }
                }

                Task.WaitAll(readContracts.ToArray());


            }
            catch (Exception ex)
            {

            }
        }

        public static void InsertItems(List<Location> demoData, HttpClient client)
        {

            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.PostAsJsonAsync("api/Location", item));
            }

            Task.WaitAll(tasks.ToArray());
        }

        private static void UpdateItems(List<Location> demoData, HttpClient client)
        {
            demoData.ForEach(c => c.StreetAndNumber = c.StreetAndNumber + "_");

            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.PutAsJsonAsync("api/Location", item));
            }

            Task.WaitAll(tasks.ToArray());
        }

        public static void DeleteItems(List<Location> demoData, HttpClient client)
        {
            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.DeleteAsync("api/Location/" + item.ID.ToString()));
            }

            Task.WaitAll(tasks.ToArray());
        }



        private static List<Location> GetDemoData()
        {
            List<Location> retVal = new List<Location>();
            retVal.Add(new Location() { ID = new Guid("60c08e77-f4e5-4663-bc0a-ec9396d2cf14"), City = "Berlin", Country = "Germany", StreetAndNumber = "Street_1" });
            retVal.Add(new Location() { ID = new Guid("c1091283-40b4-49de-8072-e21e020a3f72"), City = "Seattle", Country = "US", StreetAndNumber = "Street_2" });
            retVal.Add(new Location() { ID = new Guid("2b43168b-13c8-4622-a424-4679c4c7bb9c"), City = "Hamburg", Country = "Germany", StreetAndNumber = "Street_3" });
            retVal.Add(new Location() { ID = new Guid("d4b9902b-5169-423e-a3e0-089b927608ac"), City = "München", Country = "Germany", StreetAndNumber = "Street_4" });
            retVal.Add(new Location() { ID = new Guid("283e0d6c-44bc-4676-bca3-a6a4ddf1a0c9"), City = "Köln", Country = "Germany", StreetAndNumber = "Street_5" });
            //string s = Newtonsoft.Json.JsonConvert.SerializeObject(retVal);
            return retVal;
        }
    }
}
