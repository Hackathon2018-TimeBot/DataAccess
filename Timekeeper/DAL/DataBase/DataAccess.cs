using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Timekeeper.Models;

namespace Timekeeper.DAL
{
    public class DataAccess : IDataAccess
    {
        private const string TblNameContract = "Contract";
        private const string TblNameCustomer = "Customer";
        private const string TblNameLocation = "Location";
        private const string TblNamePerson = "Person";
        private const string TblNameProject = "Project";
        private const string TblNameResource = "Resource";
        private const string TblNameTaskType = "TaskType";
        private const string TblNameTimeBooking = "TimeBooking";

        private DocumentClient client;
        private string DatabaseId;

        #region Startup
        public DataAccess(string Endpoint, string Key, string DatabaseId, bool runSetup)
        {
            this.DatabaseId = DatabaseId;
            this.client = new DocumentClient(new Uri(Endpoint), Key);

            if (runSetup)
            {
                CreateDatabaseIfNotExistsAsync(DatabaseId).Wait();
                CreateCollectionIfNotExistsAsync(DatabaseId).Wait();
            }
        }

        private async Task CreateDatabaseIfNotExistsAsync(string DatabaseId)
        {
            try
            {
                await client.ReadDatabaseAsync(UriFactory.CreateDatabaseUri(DatabaseId));
            }
            catch (DocumentClientException e)
            {
                if (e.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    await client.CreateDatabaseAsync(new Database { Id = DatabaseId });
                }
                else
                {
                    throw;
                }
            }
        }

        private async Task CreateCollectionIfNotExistsAsync(string DatabaseId)
        {
            try
            {
                //await chkContract =
                await client.ReadDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, TblNameContract));
                //var chkCustomer =
                await client.ReadDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, TblNameCustomer));
                //var chkLocation =
                await client.ReadDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, TblNameLocation));
                //var chkPerson =
                await client.ReadDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, TblNamePerson));
                //var chkResource =
                await client.ReadDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, TblNameResource));
                //var chkTaskType =
                await client.ReadDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, TblNameTaskType));
                //var chkTimeBooking =
                await client.ReadDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, TblNameTimeBooking));

                
            }
            catch (DocumentClientException e)
            {
                if (e.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    int offerThroughput = 400;

                    await client.CreateDocumentCollectionAsync(
                        UriFactory.CreateDatabaseUri(DatabaseId),
                        new DocumentCollection { Id = TblNameContract },
                        new RequestOptions { OfferThroughput = offerThroughput });

                    await client.CreateDocumentCollectionAsync(
                        UriFactory.CreateDatabaseUri(DatabaseId),
                        new DocumentCollection { Id = TblNameCustomer },
                        new RequestOptions { OfferThroughput = offerThroughput });

                    await client.CreateDocumentCollectionAsync(
                        UriFactory.CreateDatabaseUri(DatabaseId),
                        new DocumentCollection { Id = TblNameLocation },
                        new RequestOptions { OfferThroughput = offerThroughput });

                    await client.CreateDocumentCollectionAsync(
                        UriFactory.CreateDatabaseUri(DatabaseId),
                        new DocumentCollection { Id = TblNamePerson },
                        new RequestOptions { OfferThroughput = offerThroughput });

                    await client.CreateDocumentCollectionAsync(
                        UriFactory.CreateDatabaseUri(DatabaseId),
                        new DocumentCollection { Id = TblNameProject },
                        new RequestOptions { OfferThroughput = offerThroughput });

                    await client.CreateDocumentCollectionAsync(
                        UriFactory.CreateDatabaseUri(DatabaseId),
                        new DocumentCollection { Id = TblNameResource },
                        new RequestOptions { OfferThroughput = offerThroughput });

                    await client.CreateDocumentCollectionAsync(
                        UriFactory.CreateDatabaseUri(DatabaseId),
                        new DocumentCollection { Id = TblNameTaskType },
                        new RequestOptions { OfferThroughput = offerThroughput });

                    await client.CreateDocumentCollectionAsync(
                        UriFactory.CreateDatabaseUri(DatabaseId),
                        new DocumentCollection { Id = TblNameTimeBooking },
                        new RequestOptions { OfferThroughput = offerThroughput });
                }
                else
                {
                    throw;
                }
            }
        }
        #endregion

        #region CRUD
        public async Task<T> GetItem<T>(string CollectionId, string id)
        {
            try
            {
                Document document = await client.ReadDocumentAsync(UriFactory.CreateDocumentUri(DatabaseId, CollectionId, id));
                return (T)(dynamic)document;
            }
            catch (DocumentClientException e)
            {
                if (e.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return default(T);
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task<IEnumerable<T>> GetItems<T>(string CollectionId, Expression<Func<T, bool>> predicate)
        {
            IDocumentQuery<T> query = client.CreateDocumentQuery<T>(
                UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId),
                new FeedOptions { MaxItemCount = -1 })
                .Where(predicate)
                .AsDocumentQuery();

            List<T> results = new List<T>();
            while (query.HasMoreResults)
            {
                results.AddRange(await query.ExecuteNextAsync<T>());
            }

            return results;
        }

        public async Task<ResourceResponse<Document>> CreateItem<T>(T item) where T : IBaseModel
        {
            var retVal = await client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, item.CollectionId), item);
            return retVal;
        }

        public async Task<ResourceResponse<Document>> UpdateItem<T>(T item) where T : IBaseModel
        {
            return await client.ReplaceDocumentAsync(UriFactory.CreateDocumentUri(DatabaseId, item.CollectionId, item.ID.ToString()), item);
        }

        public async Task<ResourceResponse<Document>> DeleteItemAsync(string CollectionId, string id)
        {
            return await client.DeleteDocumentAsync(UriFactory.CreateDocumentUri(DatabaseId, CollectionId, id));
        }
        #endregion
    }
}
