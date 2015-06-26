using Bradaz.Clarizen.API.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bradaz.Clarizen.API
{
    // TODO - Remove public references to QueryReponse.

    /// <summary>
    /// 
    /// </summary>
    public class Data 
    {
        #region fields
       private Query query;
       private IClarizenResponse queryResponse;
       private string rawResponse;
        #endregion

       #region properties
       public IClarizenResponse Response
       {
           get { return queryResponse; }
           set { queryResponse = value; }
       }

        /// <summary>
        /// Raw response ready to be converted to the relevant strongly typed version.
        /// </summary>
       public string RawResponse
       {
           get { return rawResponse; }
           set { rawResponse = value; }
       }
       public Query Query
       {
           get { return query; }
           set { query = value; }
       }
       #endregion

        #region methods
        /// <summary>
        /// This method will be called when chaining methods to build the relevant CZQL. A presumption
        /// has been made that the chain methods in the <see cref="Query"/> have been called.
        /// 
        /// </summary>
        internal void SetQuery()
        {
            query.ChainCZQL();
        }

        /// <summary>
        /// Pass manually a CZQL Query.
        /// </summary>
        /// <param name="queryString"></param>
        public void SetQuery(string queryString)
        {
            query.CZQL = queryString;
        }

        /// <summary>
        /// Pass manually a CZQL Query and Paging Limit.
        /// </summary>
        /// <param name="queryString"></param>
        /// <param name="limit"></param>

        public void SetQuery(string queryString, int limit)
        {
            query.CZQL = queryString;
            query.Paging.Limit = limit;

        }

        public void SetResponse(IClarizenResponse response)
        {

                this.queryResponse = response;

        }

        #endregion

        #region constructors
        /// <summary>
        /// Default contructor.
        /// </summary>
        public Data()
        {
            query = new Query();
        }
        #endregion

    }




    /// <summary>
    /// Represents CZQL (Clarizen Query Language). Details can be found here:
    ///  https://api.clarizen.com/V2.0/services/data/Query
    /// </summary>
    public class Query  : IClarizenQuery
    {
        /// <summary>
        /// The CZQL Query to perform.
        /// </summary>
        private string q;

        #region Dynamic CZQL fields (ignored when serializing)
        [JsonIgnore]
        private string selectQuery;
        [JsonIgnore]
        private string fromQuery;
        [JsonIgnore]
        private string whereQuery;
        [JsonIgnore]
        private string groupByQuery;
        [JsonIgnore]
        private string orderByQuery;
        [JsonIgnore]
        private int limitQuery;
        [JsonIgnore]
        private int offsetQuery;
        [JsonIgnore]
        private string limitAndOffsetQuery;
        #endregion

        [JsonProperty("q")]
        public string CZQL
        {
            get { return q;}
            set { q = value;}
        }

        /// <summary>
        /// Validate if a Query has been setup.
        /// </summary>
        /// <returns></returns>
        [JsonIgnore]
        public bool IsQueryBuilt
        {
            get
            {
                if (string.IsNullOrWhiteSpace(CZQL))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
      
        }
        #region chaining methods to build the CZQL dynamically.
        /// <summary>
        ///  Build the CZQL SELECT Statement.
        /// </summary>
        /// <remarks>Do not include the SELECT in the query parameter. The method will remove this.</remarks>
        /// <param name="query">Should only contain the names of the Fields you wish to select (and NOT the SELECT Statement).</param>
        /// <returns>self (chaining)</returns>
        /// <example>
        /// This sample shows how to call <see cref="Select"/> method
        /// <code>
        /// client.Data.Query.Select("Name,Work");
        /// </code>
        /// </example>
        public IClarizenQuery Select(string query)
        {
            Debug.WriteLine("Select-1 " + query);

            query = ReplaceQueryCommand(query);
            selectQuery = "SELECT " + query;

            Debug.WriteLine("Select-2 " + selectQuery);
            return this;
        }

        /// <summary>
        ///  Build the CZQL FROM Statement.
        /// </summary>
        /// <remarks>Do not include the FROM in the query parameter. The method will remove this.</remarks>
        /// <param name="query">Should only contain the names of the Table you wish to select (and NOT the FROM Statement).</param>
        /// <returns>self (chaining)</returns>
        /// <example>
        /// This sample shows how to call <see cref="Select"/> method
        /// <code>
        /// client.Data.Query.Select("Name,Work")
        ///                  .From("Task");
        /// </code>
        /// </example>
        public IClarizenQuery From(string query)
        {
            Debug.WriteLine("From-1 " + query);

            query = ReplaceQueryCommand(query);
            fromQuery = " FROM " + query;
            Debug.WriteLine("From-2 " + fromQuery);
            return this;
        }

        /// <summary>
        ///  Build the CZQL WHERE Statement.
        /// </summary>
        /// <remarks>Do not include the WHERE in the query parameter. The method will remove this.</remarks>
        /// <param name="query">Should only contain the names of the fields to pass conditions for (and NOT the WHERE Statement).</param>
        /// <returns>self (chaining)</returns>
        /// <example>
        /// This sample shows how to call <see cref="Select"/> method
        /// <code>
        /// client.Data.Query.Select("Name,Work")
        ///                  .From("Task");
        ///                  .wHERE("StartDate>2015-06-01")
        /// </code>
        /// </example>
        public IClarizenQuery Where(string query)
        {
            Debug.WriteLine("Where-1 " + query);

            query = ReplaceQueryCommand(query);
            whereQuery = " WHERE " + query;
            Debug.WriteLine("Where-2 " + fromQuery);
            return this;
        }

        public IClarizenQuery GroupBy(string query)
        {
            throw new NotImplementedException();
        }

        public IClarizenQuery OrderBy(string query)
        {
            throw new NotImplementedException();
        }

        public IClarizenQuery Limit(int rows, int offset)
        {
            Debug.WriteLine("Limit-1 - rows " + rows + " offset " + offset);

            limitQuery = rows;
            offsetQuery = offset;
            limitAndOffsetQuery = " LIMIT " + rows + " OFFSET " + offset;
            return this;
        }
        #endregion

        internal void ChainCZQL()
        {
            q = string.Empty;

            if(!string.IsNullOrWhiteSpace(selectQuery))
            {
                q += selectQuery;
                Debug.WriteLine("ChainCZQL-1: " + selectQuery);
            }

            if (!string.IsNullOrWhiteSpace(fromQuery))
            {
                q += fromQuery;
                Debug.WriteLine("ChainCZQL-2: " + fromQuery);
            }

            if (!string.IsNullOrWhiteSpace(whereQuery))
            {
                q += whereQuery;
                Debug.WriteLine("ChainCZQL-3: " + whereQuery);
            }

            if (!string.IsNullOrWhiteSpace(groupByQuery))
            {
                q += groupByQuery;
                Debug.WriteLine("ChainCZQL-4: " + groupByQuery);
            }

            if (!string.IsNullOrWhiteSpace(orderByQuery))
            {
                q += orderByQuery;
                Debug.WriteLine("ChainCZQL-5: " + orderByQuery);
            }

            if(limitQuery > 0)
            {
                if (!string.IsNullOrWhiteSpace(limitAndOffsetQuery))
                {
                    q += limitAndOffsetQuery;
                    Debug.WriteLine("ChainCZQL-6: " + limitAndOffsetQuery);
                }
                Paging.Limit = limitQuery;
            }

            Paging.From = offsetQuery;
        }



        /// <summary>
        /// Looks for a pattern for the QueryCommand (like SELECT) in specific query
        /// and removed the command.
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        private string ReplaceQueryCommand(string query)
        {
            //TODO - remove the pattern and have a global
            //Replace if SELECT is included.

            foreach (string statement in ClarizenSession.CZQLStatements)
            {
                if (Regex.IsMatch(query, statement))
                {
                    //Firstly replace with whitepace.
                    Regex rgx1 = new Regex(statement);
                    string result = rgx1.Replace(query, " ");
                    if (ClarizenSession.ConsoleDebug)
                    {
                        Console.WriteLine("Query 2 " + result);
                    }

                    //Then replace the white space.
                    string patternWhiteSpace = "\\s+";
                    string replacement = " ";
                    Regex rgx2 = new Regex(patternWhiteSpace);
                    query = rgx2.Replace(result, replacement);

                    if (ClarizenSession.ConsoleDebug)
                    {
                        Console.WriteLine("Query 3 " + query);
                    }

                }
            }

            return query;
        }

        /// <summary>
        /// Values for bind parameters.
        /// </summary>
        [JsonProperty("parameters")]
        public List<Parameter> Parameters    {get; set;}

        /// <summary>
        /// Paging setting for the query.
        /// </summary>
        [JsonProperty("paging")]
        public Paging Paging { get; set; }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Query()
        {
            Paging = new Paging();
            Parameters = new List<Parameter>();
        }

    }

    #region Responses to Queries
    /// <summary>
    /// Response from the CZQL in <see cref="Query.cs"/>
    /// </summary>
    public class QueryResponse : IClarizenResponse
    {

        /// <summary>
        /// Paging information returned from <see cref="Query.cs"/>. If paging.hasMore is true, this object should be passed as is, to the same query API in order to retrieve the next page
        /// </summary>
        [JsonProperty("paging")]
        public Paging Paging { get; set; }

        [JsonIgnore]
        public DateTime ResponseReceived { get; set; }

        public QueryResponse()
        {
            ResponseReceived = DateTime.Now;
        }
        
    }
    public class TaskResponse : QueryResponse
    {

        /// <summary>
        /// Array of entities returned from <see cref="Query.cs"/>
        /// </summary>
        [JsonProperty("entities")]
        public List<Bradaz.Clarizen.API.Models.Task> Tasks { get; set; }


        /// <summary>
        /// Default constructor for ClarizenTasks.
        /// </summary>
        public TaskResponse()
        {
            this.Tasks = new List<Bradaz.Clarizen.API.Models.Task>();

        }
    }

    public class OrganizationResponse : QueryResponse
    {
                  /// <summary>
        /// Array of entities returned from <see cref="Query.cs"/>
        /// </summary>
        [JsonProperty("entities")]
        public List<ClarizenOrganization> Organisation { get; set; }


        /// <summary>
        /// Default constructor for ClarizenTasks.
        /// </summary>
        public OrganizationResponse()
        {
            this.Organisation = new List<ClarizenOrganization>();

        }


    }
    #endregion

#region Enumerators to Reponses
    /// <summary>
    /// Enumerator class for <see cref="Data.cs"/>
    /// </summary>
    public class OrgResponseEnumerator : IEnumerator
    {
        private readonly List<ClarizenOrganization> entity;
        private int position = -1;

        /// <summary>
        /// Default constructor which sets up a readonly version of our
        /// response.
        /// </summary>
        /// <param name="response"></param>
        public OrgResponseEnumerator(List<ClarizenOrganization> entity)
        {
            this.entity = entity;
        }

        public IClarizenEntity Current
        {
            get
            {
                try
                {
                    return entity[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < entity.Count);
        }

        public void Reset()
        {
            position = -1;
        }

    }

#endregion

}             

