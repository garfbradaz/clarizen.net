﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Clarizen.Net.DataAccessLayer.Models
{

    public partial class DiscussionMessage  : ClarizenEntity
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

        [JsonProperty("EntityType")]
        public string EntityType { get; set; }

        [JsonProperty("ExternalID")]
        public string ExternalID { get; set; }

        [JsonProperty("Container")]
        public string Container { get; set; }

        [JsonProperty("ObjectAlias")]
        public string ObjectAlias { get; set; }

        [JsonProperty("Body")]
        public string Body { get; set; }

        [JsonProperty("Via")]
        public string Via { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("Style")]
        public string Style { get; set; }

        [JsonProperty("AttachmentsCount")]
        public int AttachmentsCount { get; set; }

        [JsonProperty("LikesCount")]
        public int LikesCount { get; set; }

        [JsonProperty("Post")]
        public string Post { get; set; }
    }

}