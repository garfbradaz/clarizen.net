using System.Collections.Generic;
using Newtonsoft.Json;

namespace Clarizen.Net.DataAccessLayer.Models
{


    /// <summary>
    /// Clarizen paramater object to be used when querying (Used for binding purposes).
    /// https://api.clarizen.com/V2.0/services/types/Parameters
    /// </summary>
    public class Parameter
    {

        [JsonProperty("parameter")]
        public Dictionary<string, string> QueryParameter;
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Parameter()
        {
            QueryParameter = new Dictionary<string, string>();
        }

    }

    /// <summary>
    /// Clarizen paging parameter used when querying.
    /// https://api.clarizen.com/V2.0/services/types/Paging
    /// </summary>
    public class Paging
    {

        /// <summary>
        /// The record number to start retrieve from.
        /// </summary>
        private int from;
        [JsonProperty("from")]
        public int From
        {
            get { return from; }
            set { from = value; }
        }

        /// <summary>
        /// Number of records to retrieve.
        /// </summary>
        private int limit;
        [JsonProperty("limit")]
        public int Limit
        {
            get { return limit; }
            set { limit = value; }
        }

        /// <summary>
        /// When a query results is returned, indicates whether there are more records to fetch for this query
        /// </summary>
        private bool hasMore;
        [JsonProperty("hasMore")]
        public bool HasMore
        {
            get { return hasMore; }
            set { hasMore = value; }
        }
     
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Paging  ()
        {
            limit = 100;
            from = 0;
            hasMore = false;
        }
    }


    /// <summary>
    ///  Represents the unique Id of an entity in Clarizen. 
    /// </summary>
    public class EntityId
    {

        private string id;
        [JsonProperty("id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

    }


    /// <summary>
    /// Base implementation of Clarizen entity returned in a response.
    /// </summary>
    public class Entity
    {
        private EntityId id;
        [JsonProperty("id")]
        public EntityId Id
        {
            get { return id; }
            set { id = value;}
        }

        /// <summary>
        /// Object fields in JSON format i.e. {
        /// field1: value1, 
        /// field2: value2
        /// }
        /// </summary>
        private string objectFields;
        [JsonProperty("objectFields")]
        public string Response
        {
            get { return objectFields; }
            set { objectFields = value; }
        }

    }

    public class Duration
    {
        public string unit { get; set; }
        public double value { get; set; }
    }
}
