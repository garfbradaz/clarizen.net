﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Clarizen.Net.DataAccessLayer.Models
{

    public partial class ProfileLink  : ClarizenEntity
    { /*Root*/

        [JsonProperty("CreatedBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("LastUpdatedBy")]
        public string LastUpdatedBy { get; set; }

        [JsonProperty("LastUpdatedOn")]
        public DateTime LastUpdatedOn { get; set; }

        [JsonProperty("LastUpdatedBySystemOn")]
        public DateTime LastUpdatedBySystemOn { get; set; }

        [JsonProperty("Container")]
        public string Container { get; set; }

        [JsonProperty("Member")]
        public string Member { get; set; }

        [JsonProperty("ExternalID")]
        public string ExternalID { get; set; }

        [JsonProperty("EntityType")]
        public string EntityType { get; set; }
    }

}
