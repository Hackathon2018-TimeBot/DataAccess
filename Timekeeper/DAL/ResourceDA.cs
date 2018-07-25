using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Timekeeper.Models;
using Timekeeper.Models.DataModels;
using TkResource = Timekeeper.Models.DataModels.Resource;

namespace Timekeeper.DAL
{
    public class ResourceDA
    {
        private IDataAccess DA { get; }
        private string CollectionId { get; }

        public ResourceDA(ref IDataAccess da, string CollectionId)
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

        public TkResource GetItem(string id)
        {
            //Todo: Check if user is allowed to do this


            //GetItem
            return Helper.GetAsyncResult(DA.GetItem<TkResource>(CollectionId, id));
        }

        public IEnumerable<TkResource> GetItems<TkResource>()
        {
            //Todo: Apply userfilter

            //GetItems
            return Helper.GetAsyncResult(DA.GetItems<TkResource>(CollectionId, d => d != null));
        }

        public ResourceResponse<Document> Insert(TkResource value)
        {
            //Todo: Permissioncheck

            //InsertItems
            return Helper.GetAsyncResult<ResourceResponse<Document>>(DA.CreateItem(value));
        }

        public ResourceResponse<Document> Update(TkResource value)
        {
            //Todo: Permissioncheck

            //UpdateItems
            return Helper.GetAsyncResult<ResourceResponse<Document>>(DA.UpdateItem(value));
        }
    }
}
