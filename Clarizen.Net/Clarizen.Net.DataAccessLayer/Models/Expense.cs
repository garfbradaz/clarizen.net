﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Clarizen.Net.DataAccessLayer.Models
{

    public partial class Expense  : ClarizenEntity
    { /*Root*/

        [JsonProperty("CreatedBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("LastUpdatedBy")]
        public string LastUpdatedBy { get; set; }

        [JsonProperty("LastUpdatedOn")]
        public DateTime LastUpdatedOn { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("WorkItem")]
        public string WorkItem { get; set; }

        [JsonProperty("AttachmentsCount")]
        public int AttachmentsCount { get; set; }

        [JsonProperty("Category")]
        public string Category { get; set; }

        [JsonProperty("DateIncurred")]
        public DateTime DateIncurred { get; set; }

        [JsonProperty("DateInvoiced")]
        public DateTime DateInvoiced { get; set; }

        [JsonProperty("LocalAmount")]
        public LocalAmount LocalAmount { get; set; }

        [JsonProperty("BillingAmount")]
        public BillingAmount BillingAmount { get; set; }

        [JsonProperty("ExchangeRate")]
        public double ExchangeRate { get; set; }

        [JsonProperty("Billable")]
        public bool Billable { get; set; }

        [JsonProperty("Receipt")]
        public bool Receipt { get; set; }

        [JsonProperty("Reimburse")]
        public bool Reimburse { get; set; }

        [JsonProperty("Comment")]
        public string Comment { get; set; }

        [JsonProperty("ExpenseSheet")]
        public string ExpenseSheet { get; set; }

        [JsonProperty("LastUpdatedBySystemOn")]
        public DateTime LastUpdatedBySystemOn { get; set; }

        [JsonProperty("Amount")]
        public Amount Amount { get; set; }

        [JsonProperty("Charged")]
        public bool Charged { get; set; }

        [JsonProperty("ExternalID")]
        public string ExternalID { get; set; }

        [JsonProperty("EntityType")]
        public string EntityType { get; set; }

        [JsonProperty("LikesCount")]
        public int LikesCount { get; set; }
    }

}