using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Timekeeper.Models
{
    public interface IBaseModel
    {
        [JsonProperty(PropertyName ="id")]
        Guid ID { get;}

        [JsonIgnore]
        string CollectionId { get;}
        /// <summary>
        /// Created in UTC
        /// </summary>
        [JsonProperty(PropertyName ="created")]
        DateTime Created { get;}
    }
}
