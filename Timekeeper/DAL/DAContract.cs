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
    public class DAContract
    {
        private IDataAccess DA { get; }
        private string CollectionId { get; }

        public DAContract(ref IDataAccess da, string CollectionId)
        {
            this.DA = da;
            this.CollectionId = CollectionId;
        }

        public async Task<ResourceResponse<Document>> Delete(Guid id)
        {
            //Todo: Check if user is allowed to do this
            
            return await DA.DeleteItemAsync(CollectionId, id.ToString());
        }

        public async Task<Contract> GetItem(Guid id)
        {
            //Todo: Check if user is allowed to do this

            return await DA.GetItem<Contract>(CollectionId, id.ToString());
        }

        public async Task<IEnumerable<Contract>> GetItems<Contract>()
        {
            //Todo: Apply userfilter

            return await DA.GetItems<Contract>(CollectionId, d => d != null);
        }

        public async Task<ResourceResponse<Document>> Insert(Contract value)
        {
            //Todo: Permissioncheck
            return DA.CreateItem(value).Result;
        }

        public async Task<ResourceResponse<Document>> Update(Contract value)
        {
            //Todo: Permissioncheck
            return await DA.UpdateItem(value);
        }
    }
}
