using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Timekeeper.Models.DataModels
{
    public class Resource:IBaseModel
    {
        [JsonProperty(PropertyName = "id")]
        public Guid ID { get; set; }

        [JsonIgnore]
        public string CollectionId { get; } = "Resource";
        /// <summary>
        /// Created in UTC
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public DateTime Created { get; set; }

        [JsonProperty(PropertyName = "project")]
        public Guid Project { get; set; }

        [JsonProperty(PropertyName = "startdate")]
        public DateTime StartDate { get; set; }

        [JsonProperty(PropertyName = "enddate")]
        public DateTime EndDate { get; set; }

        [JsonProperty(PropertyName = "requestedhours")]
        public int RequestedHours { get; set; }

        [JsonProperty(PropertyName = "person")]
        public Guid Person { get; set; }

        [JsonProperty(PropertyName = "resourcerole")]
        public string ResourceRole { get; set; }

        [JsonProperty(PropertyName = "timebookings")]
        public IEnumerable<Guid> TimeBookings { get; set; }

        public Resource()
        {
            this.ID = Guid.NewGuid();
            this.Created = DateTime.UtcNow;
            this.CollectionId = CollectionId;
        }

    }
}
