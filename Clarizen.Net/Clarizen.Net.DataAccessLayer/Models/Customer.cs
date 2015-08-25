﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Clarizen.Net.DataAccessLayer.Models
{

    public partial class Customer  : ClarizenEntity
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

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("BusinessAddress")]
        public string BusinessAddress { get; set; }

        [JsonProperty("BillingAddress")]
        public string BillingAddress { get; set; }

        [JsonProperty("SYSID")]
        public string SYSID { get; set; }

        [JsonProperty("LastUpdatedBySystemOn")]
        public DateTime LastUpdatedBySystemOn { get; set; }

        [JsonProperty("InternalId")]
        public string InternalId { get; set; }

        [JsonProperty("Owner")]
        public string Owner { get; set; }

        [JsonProperty("SfExternalId")]
        public string SfExternalId { get; set; }

        [JsonProperty("AccountStatus")]
        public string AccountStatus { get; set; }

        [JsonProperty("SfExternalName")]
        public string SfExternalName { get; set; }

        [JsonProperty("Tier")]
        public string Tier { get; set; }

        [JsonProperty("EntityType")]
        public string EntityType { get; set; }

        [JsonProperty("Industry")]
        public string Industry { get; set; }

        [JsonProperty("LastDateContacted")]
        public DateTime LastDateContacted { get; set; }

        [JsonProperty("CustomerValue")]
        public CustomerValue CustomerValue { get; set; }

        [JsonProperty("URL")]
        public string URL { get; set; }

        [JsonProperty("Region")]
        public string Region { get; set; }

        [JsonProperty("MarketingSource")]
        public string MarketingSource { get; set; }

        [JsonProperty("TechnicalAccountManager")]
        public string TechnicalAccountManager { get; set; }

        [JsonProperty("CustomerSuccessStatus")]
        public string CustomerSuccessStatus { get; set; }

        [JsonProperty("CompanySize")]
        public string CompanySize { get; set; }

        [JsonProperty("OfficePhone")]
        public string OfficePhone { get; set; }

        [JsonProperty("AttachmentsCount")]
        public int AttachmentsCount { get; set; }

        [JsonProperty("LikesCount")]
        public int LikesCount { get; set; }

        [JsonProperty("EmailsCount")]
        public int EmailsCount { get; set; }

        [JsonProperty("ImageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("NotesCount")]
        public int NotesCount { get; set; }
    }

}
