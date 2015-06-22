using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bradaz.Clarizen.API
{

    /// <summary>
    /// Interface that represents Custom Applications installed/created on each sites
    /// implementation.
    /// </summary>
    public interface IClarizenCustomApplication
    {
        bool IsApplicationInstalled { get; }
    }
}
