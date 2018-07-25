using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Timekeeper.Models;

namespace Timekeeper.DAL
{
    public interface IDataAccess
    {
        Task<T> GetItem<T>(string CollectionId, string id);
        Task<IEnumerable<T>> GetItems<T>(string CollectionId, Expression<Func<T, bool>> predicate);
        Task<ResourceResponse<Document>> CreateItem<T>(T item) where T : IBaseModel;
        Task<ResourceResponse<Document>> UpdateItem<T>(T item) where T : IBaseModel;
        Task<ResourceResponse<Document>> DeleteItemAsync(string CollectionId, string id);
    }
}
