﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bradaz.Clarizen.API.Models
{

    /// <summary>
    ///   Clarizen Entity for Organization.
    /// </summary>
    public class ClarizenOrganization : IClarizenEntity
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("C_TrelloAPIKey")]
        public string CTrelloAPIKey { get; set; }
    }

    public class Example
    {

        [JsonProperty("entities")]
        ///public IList<ClarizenOrganization> Organization { get; set; }
        public ClarizenOrganization Organization { get; set; }
    }
}