using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bradaz.Clarizen.API
{

    /// <summary>
    /// Interface to help us build (without LINQ currently) the relevant CZQL queries
    /// </summary>
    public interface IClarizenQuery 
    {
        IClarizenQuery Select(string query);
       
        IClarizenQuery From(string query);
        IClarizenQuery Where(string query);
        IClarizenQuery GroupBy(string query);
        IClarizenQuery OrderBy(string query);
        IClarizenQuery Limit(int rows, int offset);
        
    }
}
