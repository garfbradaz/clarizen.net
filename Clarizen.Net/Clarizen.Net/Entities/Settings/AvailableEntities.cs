using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bradaz.Clarizen.API.Models
{
    public class AvailableEntities
    {

        [JsonProperty("typeNames")]
        public List<string> TypeNames { get; set; }
    }
}
