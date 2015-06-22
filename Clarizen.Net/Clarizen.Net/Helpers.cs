using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bradaz.Clarizen.Helpers
{

    /// <summary>
    /// Helper extension methods.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Intialize a string.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static void Clear(this string str)
        {

            str = string.Empty;
        }

    }
}

