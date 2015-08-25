﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Clarizen.Net.DataAccessLayer.Models
{

    public partial class ReviewerLink  : ClarizenEntity
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

        [JsonProperty("Resource")]
        public string Resource { get; set; }

        [JsonProperty("RemainingEffort")]
        public RemainingEffort RemainingEffort { get; set; }

        [JsonProperty("Units")]
        public double Units { get; set; }

        [JsonProperty("ExternalID")]
        public string ExternalID { get; set; }

        [JsonProperty("ResourceRole")]
        public string ResourceRole { get; set; }

        [JsonProperty("Work")]
        public Work Work { get; set; }

        [JsonProperty("WorkManuallySet")]
        public bool WorkManuallySet { get; set; }

        [JsonProperty("RemainingEffortManuallySet")]
        public bool RemainingEffortManuallySet { get; set; }

        [JsonProperty("UnitsManuallySet")]
        public bool UnitsManuallySet { get; set; }

        [JsonProperty("Duration")]
        public Duration Duration { get; set; }

        [JsonProperty("ActualRegularEffort")]
        public ActualRegularEffort ActualRegularEffort { get; set; }

        [JsonProperty("ActualRegularManuallySet")]
        public bool ActualRegularManuallySet { get; set; }

        [JsonProperty("ActualOvertimeEffort")]
        public ActualOvertimeEffort ActualOvertimeEffort { get; set; }

        [JsonProperty("ActualOvertimeEffortManuallySet")]
        public bool ActualOvertimeEffortManuallySet { get; set; }

        [JsonProperty("LastUpdatedBySystemOn")]
        public DateTime LastUpdatedBySystemOn { get; set; }

        [JsonProperty("WorkVariance")]
        public WorkVariance WorkVariance { get; set; }

        [JsonProperty("Role")]
        public string Role { get; set; }

        [JsonProperty("Availability")]
        public double Availability { get; set; }

        [JsonProperty("EntityType")]
        public string EntityType { get; set; }

        [JsonProperty("PercentCompleted")]
        public double PercentCompleted { get; set; }

        [JsonProperty("CompletnessDefinition")]
        public long CompletnessDefinition { get; set; }

        [JsonProperty("PendingTime")]
        public PendingTime PendingTime { get; set; }

        [JsonProperty("RevenueRegularRate")]
        public RevenueRegularRate RevenueRegularRate { get; set; }

        [JsonProperty("RevenueOvertimeRate")]
        public RevenueOvertimeRate RevenueOvertimeRate { get; set; }
    }

}
