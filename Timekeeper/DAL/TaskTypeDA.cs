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
    public class TaskTypeDA
    {
        private IDataAccess DA { get; }
        private string CollectionId { get; }

        public TaskTypeDA(ref IDataAccess da, string CollectionId)
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

        public TaskType GetItem(string id)
        {
            //Todo: Check if user is allowed to do this


            //GetItem
            return Helper.GetAsyncResult(DA.GetItem<TaskType>(CollectionId, id));
        }

        public IEnumerable<TaskType> GetItems<TaskType>()
        {
            //Todo: Apply userfilter

            //GetItems
            return Helper.GetAsyncResult(DA.GetItems<TaskType>(CollectionId, d => d != null));
        }

        public ResourceResponse<Document> Insert(TaskType value)
        {
            //Todo: Permissioncheck

            //InsertItems
            return Helper.GetAsyncResult<ResourceResponse<Document>>(DA.CreateItem(value));
        }

        public ResourceResponse<Document> Update(TaskType value)
        {
            //Todo: Permissioncheck

            //UpdateItems
            return Helper.GetAsyncResult<ResourceResponse<Document>>(DA.UpdateItem(value));
        }
    }
}
