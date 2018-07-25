using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Timekeeper.Models;
using Timekeeper.Models.DataModels;

namespace Timekeeper.DAL
{
    public class PersonDA
    {
        private IDataAccess DA { get; }
        private string CollectionId { get; }

        public PersonDA(ref IDataAccess da, string CollectionId)
        {
            this.DA = da;
            this.CollectionId = CollectionId;
        }

        public ResourceResponse<Document> Delete(string id)
        {
            //Todo: Check if user is allowed to do this


            //Delete
            return Helper.GetAsyncResult<ResourceResponse<Document>>(DA.DeleteItemAsync(CollectionId, id));
        }

        public Person GetItem(string id)
        {
            //Todo: Check if user is allowed to do this


            //GetItem
            return Helper.GetAsyncResult<Person>(DA.GetItem<Person>(CollectionId, id));
        }

        public IEnumerable<Person> GetItems<Person>()
        {
            //Todo: Apply userfilter

            //GetItems
            return Helper.GetAsyncResult<IEnumerable<Person>>(DA.GetItems<Person>(CollectionId, d => d != null));
        }

        public ResourceResponse<Document> Insert(Person value)
        {
            //Todo: Permissioncheck

            //InsertItems
            return Helper.GetAsyncResult<ResourceResponse<Document>>(DA.CreateItem(value));
        }

        public ResourceResponse<Document> Update(Person value)
        {
            //Todo: Permissioncheck

            //UpdateItems
            return Helper.GetAsyncResult<ResourceResponse<Document>>(DA.UpdateItem(value));
        }
    }
}
