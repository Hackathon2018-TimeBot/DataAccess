using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Timekeeper.Models.DataModels;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ConsoleTestapplication.Tests
{
    public static class ResourceTest
    {
        internal static void RunTest(HttpClient client)
        {
            List<Resource> demoData = GetDemoData();

            //Mass insert
            //InsertItems(demoData, client);

            //Mass read
            //GetItems(demoData, client);

            //Mass update
            //UpdateItems(demoData, client);

            //Mass delete
            //DeleteItems(demoData, client);
        }

        

        private static void GetItems(List<Resource> demoData, HttpClient client)
        {
            try
            {
                List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();

                foreach (var item in demoData)
                {
                    tasks.Add(client.GetAsync("api/Resource/" + item.ID.ToString()));
                }

                Task.WaitAll(tasks.ToArray());

                List<Task<Resource>> readContracts = new List<Task<Resource>>();
                foreach (Task<HttpResponseMessage> t in tasks)
                {
                    if (t.IsCompletedSuccessfully)
                    {
                        readContracts.Add(t.Result.Content.ReadAsAsync<Resource>());
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

        public static void InsertItems(List<Resource> demoData, HttpClient client)
        {

            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.PostAsJsonAsync("api/Resource", item));
            }

            Task.WaitAll(tasks.ToArray());
        }

        private static void UpdateItems(List<Resource> demoData, HttpClient client)
        {
            demoData.ForEach(c => c.ResourceRole = c.ResourceRole + "_");

            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.PutAsJsonAsync("api/Resource", item));
            }

            Task.WaitAll(tasks.ToArray());
        }

        public static void DeleteItems(List<Resource> demoData, HttpClient client)
        {
            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.DeleteAsync("api/Resource/" + item.ID.ToString()));
            }

            Task.WaitAll(tasks.ToArray());
        }



        private static List<Resource> GetDemoData()
        {
            List<Resource> retVal = new List<Resource>();
            retVal.Add(new Resource() { ID = new Guid("d2c33e73-a678-41f2-ace3-dd6d3e84584f"), ResourceRole = "Role_1" });
            retVal.Add(new Resource() { ID = new Guid("1ef8b166-c35e-4ac5-a512-603caeb9c7fb"), ResourceRole = "Role_2" });
            retVal.Add(new Resource() { ID = new Guid("de80d38a-eb41-44b3-ade0-a43fa7a50500"), ResourceRole = "Role_3" });
            retVal.Add(new Resource() { ID = new Guid("784f0ca8-c2d2-4d46-9423-19c70620cfd5"), ResourceRole = "Role_4" });
            retVal.Add(new Resource() { ID = new Guid("f5f79d00-7076-4626-95c4-dfa8dde35d65"), ResourceRole = "Role_5" });
            
            //string s = Newtonsoft.Json.JsonConvert.SerializeObject(retVal);
            return retVal;
        }
    }
}




