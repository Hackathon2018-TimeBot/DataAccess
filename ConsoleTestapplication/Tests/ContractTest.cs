using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Timekeeper.Models.DataModels;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ConsoleTestapplication.Tests
{
    public static class ContractTest
    {
        internal static void RunTest(HttpClient client)
        {
            List<Contract> demoData = GetDemoData();

            //Mass insert
            //InsertItems(demoData, client);

            //Mass read
            //GetItems(demoData, client);

            //Mass update
            //UpdateItems(demoData, client);

            //Mass delete
            //DeleteItems(demoData, client);
        }

        

        private static void GetItems(List<Contract> demoData, HttpClient client)
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

        public static void InsertItems(List<Contract> demoData, HttpClient client)
        {

            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.PostAsJsonAsync("api/Contract", item));
            }

            Task.WaitAll(tasks.ToArray());
        }

        private static void UpdateItems(List<Contract> demoData, HttpClient client)
        {
            demoData.ForEach(c => c.Description = c.Description + "_");

            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.PutAsJsonAsync("api/Contract", item));
            }

            Task.WaitAll(tasks.ToArray());
        }

        public static void DeleteItems(List<Contract> demoData, HttpClient client)
        {
            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.DeleteAsync("api/Contract/" + item.ID.ToString()));
            }

            Task.WaitAll(tasks.ToArray());
        }



        private static List<Contract> GetDemoData()
        {
            List<Contract> retVal = new List<Contract>();
            retVal.Add(new Contract() { ID = new Guid("51b8e5e6-00a6-45f8-94f9-83b92baa835e"), Description = "Test_Contract_1" });
            retVal.Add(new Contract() { ID = new Guid("e89f2f0c-4b59-43e4-a307-f0f7bbab1e2a"), Description = "Test_Contract_2" });
            retVal.Add(new Contract() { ID = new Guid("2f0a0181-f1d8-4274-8acb-c9d2f02bbea6"), Description = "Test_Contract_3" });
            retVal.Add(new Contract() { ID = new Guid("8df6b63d-ce98-4576-ad88-b5c6e0679db9"), Description = "Test_Contract_4" });
            retVal.Add(new Contract() { ID = new Guid("e6766e81-b4af-4c66-9764-14cdb03946df"), Description = "Test_Contract_5" });
            //string s = Newtonsoft.Json.JsonConvert.SerializeObject(retVal);
            return retVal;
        }
    }
}
