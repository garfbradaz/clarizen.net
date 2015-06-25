using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bradaz.Clarizen.API
{
    /// <summary>
    /// Static values shared across each session.
    /// </summary>
    public static class ClarizenSession
    {


        #region API URLs
        /// <remarks> Urls to each RESTful API. https://api.clarizen.com/V2.0/services/ </remarks>
        public static string BaseAddress = "https://api.clarizen.com/v2.0/services";
        public static string GetServerDefinition = "/getServerDefinition";
        public static string Authentication = "/authentication";
        public static string Login = "/authentication/login";
        public static string DescribeMetadata = "/metadata/describeMetadata";
        public static string DescribeEntities = "/metadata/describeEntities";
        public static string DataQuery = "/data/query";
        public static string ListEntities = "/metadata/listEntities";
        #endregion

        public static string AuthenticatedServerLocation = string.Empty;
        public static string UserName = string.Empty;
        public static string Password = string.Empty;
        public static string SessionId = string.Empty;
        public static bool HasAuthenticated = false;
        public static bool ConsoleDebug = false;


        /// <summary>
        /// CZQL (Clarizen Query Language) Statements.
        /// <remarks>They are case sensitive</remarks>
        /// </summary>
        public static List<String> CZQLStatements = new List<string> {
            "SELECT",
            "FROM",
            "WHERE",
            "GROUP BY",
            "ORDER BY",
            "LIMIT",
            "OFFSET"

        };


        /// <summary>
        /// Disctionary of Entity Descriptions and their Types.
        /// </summary>
        public static Dictionary<string, entityType> Entities = new Dictionary<string, entityType>() 
        {       
                {"Bug",entityType.Bug},
                {"Case",entityType.Case},
                {"Issue",entityType.Issue},
                {"Milestone",entityType.Milestone},
                {"Project",entityType.Project},
                {"Request",entityType.Request},
                {"Task",entityType.Task},
                {"WorkItem",entityType.WorkItem}               

        };
    }
}
