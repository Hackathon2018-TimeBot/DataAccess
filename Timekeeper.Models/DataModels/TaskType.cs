using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Timekeeper.Models.DataModels
{
    public class TaskType:IBaseModel
    {
        [JsonProperty(PropertyName = "id")]
        public Guid ID { get; set; }

        [JsonIgnore]
        public string CollectionId { get; } = "TaskType";
        /// <summary>
        /// Created in UTC
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public DateTime Created { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        public TaskType()
        {
            this.ID = Guid.NewGuid();
            this.Created = DateTime.UtcNow;
            this.CollectionId = CollectionId;
        }
    }
}
