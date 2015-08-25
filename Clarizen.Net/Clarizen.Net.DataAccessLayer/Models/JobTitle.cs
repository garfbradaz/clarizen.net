﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Clarizen.Net.DataAccessLayer.Models
{

    public partial class JobTitle  : ClarizenEntity
    { /*Root*/

        [JsonProperty("CreatedBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("LastUpdatedBy")]
        public string LastUpdatedBy { get; set; }

        [JsonProperty("LastUpdatedOn")]
        public DateTime LastUpdatedOn { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("ExternalID")]
        public string ExternalID { get; set; }

        [JsonProperty("LastUpdatedBySystemOn")]
        public DateTime LastUpdatedBySystemOn { get; set; }

        [JsonProperty("Availability")]
        public double Availability { get; set; }

        [JsonProperty("EntityType")]
        public string EntityType { get; set; }

        [JsonProperty("AttachmentsCount")]
        public int AttachmentsCount { get; set; }

        [JsonProperty("CostRegularRate")]
        public CostRegularRate CostRegularRate { get; set; }

        [JsonProperty("CostOvertimeRate")]
        public CostOvertimeRate CostOvertimeRate { get; set; }

        [JsonProperty("RevenueRegularRate")]
        public RevenueRegularRate RevenueRegularRate { get; set; }

        [JsonProperty("RevenueOvertimeRate")]
        public RevenueOvertimeRate RevenueOvertimeRate { get; set; }

        [JsonProperty("LikesCount")]
        public int LikesCount { get; set; }
    }

}
