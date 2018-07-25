using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Timekeeper.Models.DataModels
{
    public class Person:IBaseModel
    {
        [JsonProperty(PropertyName = "id")]
        public Guid ID { get; set; }

        [JsonIgnore]
        public string CollectionId { get; } = "Person";
        /// <summary>
        /// Created in UTC
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public DateTime Created { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "firstname")]
        public string Firstname { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string EMail { get; set; }

        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        [JsonProperty(PropertyName = "targethours")]
        public int TargetHours { get; set; }

        public Person()
        {
            this.ID = Guid.NewGuid();
            this.Created = DateTime.UtcNow;
            this.CollectionId = CollectionId;
        }
    }
}
