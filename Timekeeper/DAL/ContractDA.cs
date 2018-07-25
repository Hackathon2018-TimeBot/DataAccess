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
    public class ContractDA
    {
        private IDataAccess DA { get; }
        private string CollectionId { get; }

        public ContractDA(ref IDataAccess da, string CollectionId)
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

        public Contract GetItem(string id)
        {
            //Todo: Check if user is allowed to do this


            //GetItem
            return Helper.GetAsyncResult<Contract>(DA.GetItem<Contract>(CollectionId, id));
        }

        public IEnumerable<Contract> GetItems<Contract>()
        {
            //Todo: Apply userfilter

            //GetItems
            return Helper.GetAsyncResult<IEnumerable<Contract>>(DA.GetItems<Contract>(CollectionId, d => d != null));
        }

        public ResourceResponse<Document> Insert(Contract value)
        {
            //Todo: Permissioncheck

            //InsertItems
            return Helper.GetAsyncResult<ResourceResponse<Document>>(DA.CreateItem(value));
        }

        public ResourceResponse<Document> Update(Contract value)
        {
            //Todo: Permissioncheck

            //UpdateItems
            return Helper.GetAsyncResult<ResourceResponse<Document>>(DA.UpdateItem(value));
        }
    }
}
