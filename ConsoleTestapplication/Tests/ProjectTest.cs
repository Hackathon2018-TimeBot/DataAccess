using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Timekeeper.Models.DataModels;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ConsoleTestapplication.Tests
{
    public static class ProjectTest
    {
        internal static void RunTest(HttpClient client)
        {
            List<Project> demoData = GetDemoData();

            //Mass insert
            //InsertItems(demoData, client);

            //Mass read
            //GetItems(demoData, client);

            //Mass update
            //UpdateItems(demoData, client);

            //Mass delete
            //DeleteItems(demoData, client);
        }

        

        private static void GetItems(List<Project> demoData, HttpClient client)
        {
            try
            {
                List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();

                foreach (var item in demoData)
                {
                    tasks.Add(client.GetAsync("api/Project/" + item.ID.ToString()));
                }

                Task.WaitAll(tasks.ToArray());

                List<Task<Project>> readContracts = new List<Task<Project>>();
                foreach (Task<HttpResponseMessage> t in tasks)
                {
                    if (t.IsCompletedSuccessfully)
                    {
                        readContracts.Add(t.Result.Content.ReadAsAsync<Project>());
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

        public static void InsertItems(List<Project> demoData, HttpClient client)
        {

            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.PostAsJsonAsync("api/Project", item));
            }

            Task.WaitAll(tasks.ToArray());
        }

        private static void UpdateItems(List<Project> demoData, HttpClient client)
        {
            demoData.ForEach(c => c.Name = c.Name + "_");

            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.PutAsJsonAsync("api/Project", item));
            }

            Task.WaitAll(tasks.ToArray());
        }

        public static void DeleteItems(List<Project> demoData, HttpClient client)
        {
            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.DeleteAsync("api/Project/" + item.ID.ToString()));
            }

            Task.WaitAll(tasks.ToArray());
        }



        private static List<Project> GetDemoData()
        {
            List<Project> retVal = new List<Project>();
            retVal.Add(new Project() { ID = new Guid("3666a9da-6449-42ed-9cdf-bbdd82bfffbe"), Name = "Project_1" });
            retVal.Add(new Project() { ID = new Guid("d92dccd6-c37a-412a-81f0-f2d900967f8a"), Name = "Project_2" });
            retVal.Add(new Project() { ID = new Guid("2b8a7afd-1a3e-476d-beb9-56daaf6ffe07"), Name = "Project_3" });
            retVal.Add(new Project() { ID = new Guid("fc08afc0-f421-4525-8877-26f58b23c21e"), Name = "Project_4" });
            retVal.Add(new Project() { ID = new Guid("49a3e145-733f-4f55-aba0-af2ec3ec9e0f"), Name = "Project_5" });
            
            //string s = Newtonsoft.Json.JsonConvert.SerializeObject(retVal);
            return retVal;
        }
    }
}




