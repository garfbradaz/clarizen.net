﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Clarizen.Net.DataAccessLayer.Models
{

    public  class Lag 
    { /*Root*/

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public partial class DependencyLink  : ClarizenEntity
    { /*Root*/

        [JsonProperty("CreatedBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("LastUpdatedBy")]
        public string LastUpdatedBy { get; set; }

        [JsonProperty("LastUpdatedOn")]
        public DateTime LastUpdatedOn { get; set; }

        [JsonProperty("WorkItem")]
        public string WorkItem { get; set; }

        [JsonProperty("DependsOn")]
        public string DependsOn { get; set; }

        [JsonProperty("DependencyType")]
        public string DependencyType { get; set; }

        [JsonProperty("Lag")]
        public Lag Lag { get; set; }

        [JsonProperty("Shortcut")]
        public bool Shortcut { get; set; }

        [JsonProperty("LastUpdatedBySystemOn")]
        public DateTime LastUpdatedBySystemOn { get; set; }

        [JsonProperty("ExternalID")]
        public string ExternalID { get; set; }

        [JsonProperty("EntityType")]
        public string EntityType { get; set; }
    }

}
