using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Timekeeper.Models.DataModels
{
    public class TimeBooking : IBaseModel
    {
        [JsonProperty(PropertyName = "id")]
        public Guid ID { get; set; }

        [JsonIgnore]
        public string CollectionId { get; } = "TimeBooking";
        /// <summary>
        /// Created in UTC
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public DateTime Created { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "hours")]
        public int Hours { get; set; }

        [JsonProperty(PropertyName = "forcasthours")]
        public int ForecastHours { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "task")]
        public Guid Task { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public double Long { get; set; }

        [JsonProperty(PropertyName = "latitude")]
        public double Lat { get; set; }

        public TimeBooking()
        {
            this.ID = Guid.NewGuid();
            this.Created = DateTime.UtcNow;
            this.CollectionId = CollectionId;
        }
    }
}
