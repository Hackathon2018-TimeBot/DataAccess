using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Timekeeper.Models.DataModels
{
    public class Customer:IBaseModel
    {
        [JsonProperty(PropertyName = "id")]
        public Guid ID { get; set; }

        [JsonIgnore]
        public string CollectionId { get; } = "Customer";
        /// <summary>
        /// Created in UTC
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public DateTime Created { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "contracts")]
        public IEnumerable<Guid> Contracts { get; set; }

        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        [JsonProperty(PropertyName = "locations")]
        public IEnumerable<Guid> Locations { get; set; }

        public Customer()
        {
            this.ID = Guid.NewGuid();
            this.Created = DateTime.UtcNow;
            this.CollectionId = CollectionId;
        }
    }
}
