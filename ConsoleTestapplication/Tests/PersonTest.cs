using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Timekeeper.Models.DataModels;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ConsoleTestapplication.Tests
{
    public static class PersonTest
    {
        internal static void RunTest(HttpClient client)
        {
            List<Person> demoData = GetDemoData();

            //Mass insert
            //InsertItems(demoData, client);

            //Mass read
            //GetItems(demoData, client);

            //Mass update
            //UpdateItems(demoData, client);

            //Mass delete
            //DeleteItems(demoData, client);
        }

        

        private static void GetItems(List<Person> demoData, HttpClient client)
        {
            try
            {
                List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();

                foreach (var item in demoData)
                {
                    tasks.Add(client.GetAsync("api/Person/" + item.ID.ToString()));
                }

                Task.WaitAll(tasks.ToArray());

                List<Task<Person>> readContracts = new List<Task<Person>>();
                foreach (Task<HttpResponseMessage> t in tasks)
                {
                    if (t.IsCompletedSuccessfully)
                    {
                        readContracts.Add(t.Result.Content.ReadAsAsync<Person>());
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

        public static void InsertItems(List<Person> demoData, HttpClient client)
        {

            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.PostAsJsonAsync("api/Person", item));
            }

            Task.WaitAll(tasks.ToArray());
        }

        private static void UpdateItems(List<Person> demoData, HttpClient client)
        {
            demoData.ForEach(c => c.Phone = "123");

            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.PutAsJsonAsync("api/Person", item));
            }

            Task.WaitAll(tasks.ToArray());
        }

        public static void DeleteItems(List<Person> demoData, HttpClient client)
        {
            List<Task<HttpResponseMessage>> tasks = new List<Task<HttpResponseMessage>>();
            foreach (var item in demoData)
            {
                tasks.Add(client.DeleteAsync("api/Person/" + item.ID.ToString()));
            }

            Task.WaitAll(tasks.ToArray());
        }



        private static List<Person> GetDemoData()
        {
            List<Person> retVal = new List<Person>();
            retVal.Add(new Person() { ID = new Guid("dc9050ab-e9a9-4d48-a9b2-6d3a1e4ce5e3"), Firstname = "Ralf", Name = "H." });
            retVal.Add(new Person() { ID = new Guid("cc519771-951b-4ee7-b3d7-2e8229ce45ba"), Firstname = "Paul", Name = "P." });
            retVal.Add(new Person() { ID = new Guid("5fe7c14f-965e-454d-b061-26fd66f3a3a5"), Firstname = "Michael", Name = "E." });
            retVal.Add(new Person() { ID = new Guid("2fc929ae-298c-442a-910a-bd99184811d4"), Firstname = "Denis", Name = "B." });
            retVal.Add(new Person() { ID = new Guid("941905b1-2376-40d1-9332-0eb35f5e2d65"), Firstname = "Matthias", Name = "T." });

            //string s = Newtonsoft.Json.JsonConvert.SerializeObject(retVal);
            return retVal;
        }
    }
}
