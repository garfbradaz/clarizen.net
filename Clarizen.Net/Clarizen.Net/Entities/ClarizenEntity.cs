using Bradaz.Clarizen.API;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bradaz.Clarizen.API.Models
{
    public class ClarizenEntity : IClarizenEntity        
    {  
        [JsonProperty("id")]
        public string Id { get; set; }

        public ClarizenEntity ()
        {
            this.Id = string.Empty;
        }
   
    }
}
