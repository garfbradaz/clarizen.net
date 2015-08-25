using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clarizen.Net.DataAccessLayer.Models
{
    /// <summary>
    /// Describes a Clarizen Entity.
    /// </summary>
    public interface IClarizenEntity
    {
        string Id { get; }
    }
}
