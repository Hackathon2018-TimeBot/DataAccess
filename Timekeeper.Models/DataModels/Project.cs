using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Timekeeper.Models.DataModels
{
    public class Project:IBaseModel
    {
        [JsonProperty(PropertyName = "id")]
        public Guid ID { get; set; }

        [JsonIgnore]
        public string CollectionId { get; } = "Project";
        /// <summary>
        /// Created in UTC
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public DateTime Created { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "startdate")]
        public DateTime StartDate { get; set; }

        [JsonProperty(PropertyName = "enddate")]
        public DateTime EndDate { get; set; }

        [JsonProperty(PropertyName = "resources")]
        public IEnumerable<Guid> Resources { get; set; }

        public Project()
        {
            this.ID = Guid.NewGuid();
            this.Created = DateTime.UtcNow;
            this.CollectionId = CollectionId;
        }
    }
}
