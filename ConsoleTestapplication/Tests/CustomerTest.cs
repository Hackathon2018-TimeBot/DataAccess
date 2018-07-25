using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Timekeeper.Models.DataModels;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ConsoleTestapplication.Tests
{
    public static class CustomerTest
    {
        internal static void RunTest(HttpClient client)
        {
            List<Customer> demoData = GetDemoData();

            //Mass insert
            //InsertItems(demoData, client);

            //Mass read
            //GetItems(demoData, client);

            //Mass update
            //UpdateItems(demoData, client);

            //Mass delete
            //DeleteItems(demoData, client);
        }

        

        private static void GetItems(List<Customer> demoData, HttpClient client)
        {
            try
            {
                List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();

                foreach (var item in demoData)
                {
                    tasks.Add(client.GetAsync("api/Contract/" + item.ID.ToString()));
                }

                Task.WaitAll(tasks.ToArray());

                List<Task<Contract>> readContracts = new List<Task<Contract>>();
                foreach (Task<HttpResponseMessage> t in tasks)
                {
                    if (t.IsCompletedSuccessfully)
                    {
                        readContracts.Add(t.Result.Content.ReadAsAsync<Contract>());
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

        public static void InsertItems(List<Customer> demoData, HttpClient client)
        {

            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.PostAsJsonAsync("api/Customer", item));
            }

            Task.WaitAll(tasks.ToArray());
        }

        private static void UpdateItems(List<Customer> demoData, HttpClient client)
        {
            demoData.ForEach(c => c.Name = c.Name + "_");

            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.PutAsJsonAsync("api/Customer", item));
            }

            Task.WaitAll(tasks.ToArray());
        }

        public static void DeleteItems(List<Customer> demoData, HttpClient client)
        {
            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.DeleteAsync("api/Customer/" + item.ID.ToString()));
            }

            Task.WaitAll(tasks.ToArray());
        }



        private static List<Customer> GetDemoData()
        {
            List<Customer> retVal = new List<Customer>();
            retVal.Add(new Customer() { ID = new Guid("3804c146-d2cb-44c7-ad9f-03086f1a50d9"), Name = "Customer_1" });
            retVal.Add(new Customer() { ID = new Guid("75e6135a-4c8f-4e6b-8f8a-21e9a3f67241"), Name = "Customer_2" });
            retVal.Add(new Customer() { ID = new Guid("cf3e249f-ea86-4839-965e-78fa8b53af1f"), Name = "Customer_3" });
            retVal.Add(new Customer() { ID = new Guid("425095f8-44f1-4c69-beb8-748e97e0131b"), Name = "Customer_4" });
            retVal.Add(new Customer() { ID = new Guid("39c98ba4-a9cb-46ac-aa57-a80e3d322d38"), Name = "Customer_5" });

            //string s = Newtonsoft.Json.JsonConvert.SerializeObject(retVal);
            return retVal;
        }
    }
}
