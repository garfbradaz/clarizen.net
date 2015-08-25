﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Clarizen.Net.DataAccessLayer.Models
{

    public  class OccurenceDuration 
    { /*Root*/

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public partial class Dashboard  : ClarizenEntity
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

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("ExternalID")]
        public string ExternalID { get; set; }

        [JsonProperty("ImageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("SYSID")]
        public string SYSID { get; set; }

        [JsonProperty("EntityOwner")]
        public string EntityOwner { get; set; }

        [JsonProperty("AttachmentsCount")]
        public int AttachmentsCount { get; set; }

        [JsonProperty("Scheduled")]
        public bool Scheduled { get; set; }

        [JsonProperty("SchedulerPreferredTime")]
        public int SchedulerPreferredTime { get; set; }

        [JsonProperty("SchedulerNotificationType")]
        public int SchedulerNotificationType { get; set; }

        [JsonProperty("SchedulerTo")]
        public string SchedulerTo { get; set; }

        [JsonProperty("SchedulerCc")]
        public string SchedulerCc { get; set; }

        [JsonProperty("SchedulerNotificationSubject")]
        public string SchedulerNotificationSubject { get; set; }

        [JsonProperty("SchedulerNotificationBody")]
        public string SchedulerNotificationBody { get; set; }

        [JsonProperty("SchedulerPostTopics")]
        public string SchedulerPostTopics { get; set; }

        [JsonProperty("SchedulerPostNotifiers")]
        public string SchedulerPostNotifiers { get; set; }

        [JsonProperty("SchedulerSaveExportedData")]
        public bool SchedulerSaveExportedData { get; set; }

        [JsonProperty("SchedulerExportAs")]
        public string SchedulerExportAs { get; set; }

        [JsonProperty("RecurrenceType")]
        public string RecurrenceType { get; set; }

        [JsonProperty("RecurrenceInterval")]
        public int RecurrenceInterval { get; set; }

        [JsonProperty("WorkdaysOnly")]
        public bool WorkdaysOnly { get; set; }

        [JsonProperty("WeekDays")]
        public int WeekDays { get; set; }

        [JsonProperty("RecurrenceDayOfMonth")]
        public int RecurrenceDayOfMonth { get; set; }

        [JsonProperty("RecurrenceMonthOfYear")]
        public string RecurrenceMonthOfYear { get; set; }

        [JsonProperty("RecurrenceStartDate")]
        public DateTime RecurrenceStartDate { get; set; }

        [JsonProperty("RecurrenceEndDate")]
        public DateTime RecurrenceEndDate { get; set; }

        [JsonProperty("OccurenceDuration")]
        public OccurenceDuration OccurenceDuration { get; set; }

        [JsonProperty("Occurrences")]
        public int Occurrences { get; set; }

        [JsonProperty("EmailsCount")]
        public int EmailsCount { get; set; }
    }

}
