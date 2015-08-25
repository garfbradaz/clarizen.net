﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Clarizen.Net.DataAccessLayer.Models
{

    public partial class WorkItemAttachmentLink  : ClarizenEntity
    { /*Root*/

        [JsonProperty("CreatedBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("LastUpdatedBy")]
        public string LastUpdatedBy { get; set; }

        [JsonProperty("LastUpdatedOn")]
        public DateTime LastUpdatedOn { get; set; }

        [JsonProperty("Entity")]
        public string Entity { get; set; }

        [JsonProperty("Document")]
        public string Document { get; set; }

        [JsonProperty("ExternalID")]
        public string ExternalID { get; set; }

        [JsonProperty("LastUpdatedBySystemOn")]
        public DateTime LastUpdatedBySystemOn { get; set; }

        [JsonProperty("EntityType")]
        public string EntityType { get; set; }
    }

}
