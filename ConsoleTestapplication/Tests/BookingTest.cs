using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Timekeeper.Models.DataModels;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ConsoleTestapplication.Tests
{
    public static class BookingsTest
    {
        internal static void RunTest(HttpClient client)
        {
            //List<Contract> demoData = GetDemoData();

            //Mass insert
            //InsertItems(demoData, client);

            //Mass read
            //GetItems(demoData, client);

            //Mass update
            //UpdateItems(demoData, client);

            //Mass delete
            //DeleteItems(demoData, client);
        }

        

        private static void GetItems(List<TimeBooking> demoData, HttpClient client)
        {
            try
            {
                List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();

                foreach (var item in demoData)
                {
                    tasks.Add(client.GetAsync("api/TimeBooking/" + item.ID.ToString()));
                }

                Task.WaitAll(tasks.ToArray());

                List<Task<TimeBooking>> readBookings = new List<Task<TimeBooking>>();
                foreach (Task<HttpResponseMessage> t in tasks)
                {
                    if (t.IsCompletedSuccessfully)
                    {
                        readBookings.Add(t.Result.Content.ReadAsAsync<TimeBooking>());
                        //Done
                    }
                    else
                    {
                        //Error
                    }
                }

                Task.WaitAll(readBookings.ToArray());


            }
            catch (Exception ex)
            {

            }
        }

        public static void InsertItems(List<TimeBooking> demoData, HttpClient client)
        {

            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.PostAsJsonAsync("api/TimeBooking", item));
            }

            Task.WaitAll(tasks.ToArray());
        }

        private static void UpdateItems(List<TimeBooking> demoData, HttpClient client)
        {
            demoData.ForEach(c => c.Description = c.Description + "_");

            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.PutAsJsonAsync("api/TimeBooking", item));
            }

            Task.WaitAll(tasks.ToArray());
        }

        public static void DeleteItems(List<TimeBooking> demoData, HttpClient client)
        {
            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.DeleteAsync("api/TimeBooking/" + item.ID.ToString()));
            }

            Task.WaitAll(tasks.ToArray());
        }



       
    }
}
