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
    public class CustomerDA
    {
        private IDataAccess DA { get; }
        private string CollectionId { get; }

        public CustomerDA(ref IDataAccess da, string CollectionId)
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

        public Customer GetItem(string id)
        {
            //Todo: Check if user is allowed to do this


            //GetItem
            return Helper.GetAsyncResult<Customer>(DA.GetItem<Customer>(CollectionId, id));
        }

        public IEnumerable<Customer> GetItems<Contract>()
        {
            //Todo: Apply userfilter

            //GetItems
            return Helper.GetAsyncResult<IEnumerable<Customer>>(DA.GetItems<Customer>(CollectionId, d => d != null));
        }

        public ResourceResponse<Document> Insert(Customer value)
        {
            //Todo: Permissioncheck

            //InsertItems
            return Helper.GetAsyncResult<ResourceResponse<Document>>(DA.CreateItem(value));
        }

        public ResourceResponse<Document> Update(Customer value)
        {
            //Todo: Permissioncheck

            //UpdateItems
            return Helper.GetAsyncResult<ResourceResponse<Document>>(DA.UpdateItem(value));
        }
    }
}
