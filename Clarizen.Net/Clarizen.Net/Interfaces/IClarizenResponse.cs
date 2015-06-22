using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Bradaz.Clarizen.API
{
    public interface IClarizenResponse
    {
        [JsonIgnore]
        DateTime ResponseReceived { get; set; }
    }
}
