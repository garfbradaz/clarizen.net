using Newtonsoft.Json;

namespace Clarizen.Net.DataAccessLayer.Models
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
