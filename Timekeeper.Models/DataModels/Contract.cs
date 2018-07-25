using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Timekeeper.Models.DataModels
{
    public class Contract:IBaseModel
    {
        [JsonProperty(PropertyName = "id")]
        public Guid ID { get; set; }

        [JsonIgnore]
        public string CollectionId { get;} = "Contract";
        /// <summary>
        /// Created in UTC
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public DateTime Created { get;}

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "projects")]
        public IEnumerable<Guid> Projects { get; set; }
        
        public Contract()
        {
            this.ID = Guid.NewGuid();
            this.Created = DateTime.UtcNow;
        }
    }
}
