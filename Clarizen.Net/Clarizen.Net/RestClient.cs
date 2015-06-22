﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Bradaz.Clarizen.Helpers;
using System.IO;
using Bradaz.Clarizen.API.Models;
using Bradaz.Clarizen.API.Custom;
using Newtonsoft.Json.Linq;
using Bradaz.Clarizen.API.Models.DescribeEntityJsonTypes;
using System.Diagnostics;
using System.Text.RegularExpressions;


namespace Bradaz.Clarizen.API
{
   

    /// <summary>
    /// This is a synchronous Client as Clarizen currently cannot
    /// handle Asynch requests.
    /// </summary>
    public class RestClient
    {
        private WebClient ClarizenWebClient;
        private Authenticate authenticate;
        private Data data;

        public Dictionary<string, IClarizenCustomApplication> CustomApplications;
        private Dictionary<string, IClarizenResponse> dataInMemory;

        public List<Bradaz.Clarizen.API.Models.Task> Tasks
        {
            get
            {   IClarizenResponse  tr;
                TaskResponse tasks = new TaskResponse();
                if(dataInMemory.TryGetValue("Task",out tr))
                {
                       if(tr.GetType() == typeof(TaskResponse))
                       {
                           tasks = (TaskResponse)tr;
                           return tasks.Tasks;
                       }
                }
                return new List<Bradaz.Clarizen.API.Models.Task>();
                
            }
        }
        
        /// <summary>
        /// Default constructor.
        /// </summary>
        public RestClient ()
        {
            if (!string.IsNullOrWhiteSpace(ClarizenSession.UserName) && !string.IsNullOrWhiteSpace(ClarizenSession.Password))
            {
                SetupAuthentication();
                SetupData();
                CustomApplications = new Dictionary<string, IClarizenCustomApplication>();
                dataInMemory = new Dictionary<string, IClarizenResponse>();
            }
        }

        /// <summary>
        /// Contructor that takes credentials to login.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public RestClient(string username, string password)
        {
            ClarizenSession.UserName = username;
            ClarizenSession.Password = password;

            if (!string.IsNullOrWhiteSpace(ClarizenSession.UserName) && !string.IsNullOrWhiteSpace(ClarizenSession.Password))
            {
                SetupAuthentication();
                SetupData();
                CustomApplications = new Dictionary<string, IClarizenCustomApplication>();
                dataInMemory = new Dictionary<string, IClarizenResponse>();
            }
        }

        private void SetupAuthentication()
        {
            authenticate = new Authenticate();
         
        }

        private void SetupData()
        {
            data = new Data();
        }

        public Data Data
        {
            get { return data; }
            internal set {data = value;}
        }


        /// <summary>
        /// If you want to use the console to list out any debug.
        /// </summary>
        public bool Debug
        {
            get { return ClarizenSession.ConsoleDebug; }
            set { ClarizenSession.ConsoleDebug = value; }
        }


        /// <summary>
        /// Method to pull down the JSON that describes Clarizen Entities,
        /// </summary>
        public void GetAllMetadata()
        {
            
            var url = string.Empty;
            url = ClarizenSession.AuthenticatedServerLocation + ClarizenSession.DescribeMetadata;
            Get(url);
        }


        /// <summary>
        /// Method to grab Metadata.
        /// </summary>
        /// <param name="type"></param>
       public void GetAllMetadata(entityType type)
        {
            var urlWithQueryString = string.Empty;
            var url = string.Empty;
            url = ClarizenSession.AuthenticatedServerLocation + ClarizenSession.DescribeMetadata;
            try
            {
                switch (type)
                {
                    case entityType.Task:
                        urlWithQueryString = url + "?typeNames=Task&flags=fields";
                        Get(urlWithQueryString);
                        break;
                    default:
                        throw new NotImplementedException("entityType " + type + " currently is in development");

                }
            }
           catch (NotImplementedException x)
            {
                if (Debug)
                {
                    Console.WriteLine("GetAllMetadata: " + x.Message);
                }
            }
        }

       /// <summary>
       /// Method to grab Metadata.
       /// </summary>
       /// <param name="type"></param>
       public void GetAllMetadataDescribeEntities(entityType type)
       {
           var urlWithQueryString = string.Empty;
           var url = string.Empty;
           url = ClarizenSession.AuthenticatedServerLocation + ClarizenSession.DescribeEntities;
           try
           {
               switch (type)
               {
                   case entityType.Task:
                       urlWithQueryString = url + "?typeNames=Task";
                       Get(urlWithQueryString);
                       break;
                   default:
                       throw new NotImplementedException("entityType " + type + " currently is in development");

               }
           }
           catch (NotImplementedException x)
           {
                    if(Debug)
                   {
                       Console.WriteLine("GetAllMetadata: " + x.Message); 
                   }
           }
       }


        /// <summary>
        /// Get the MetaData for all of the Fields for a particular Clarizen Entity.
        /// </summary>
        /// <param name="type"></param>
       public void GetAllMetadataDescribeEntitiesAndGetAllFields(entityType type)
       {
           var urlWithQueryString = string.Empty;
           var url = string.Empty;
           url = ClarizenSession.AuthenticatedServerLocation + ClarizenSession.DescribeEntities;
           try
           {
               switch (type)
               {
                   case entityType.Task:
                       urlWithQueryString = url + "?typeNames=Task";
                       Get(urlWithQueryString,entityType.Task);
                       break;
                   default:
                       throw new NotImplementedException("entityType " + type + " currently is in development");

               }
           }
           catch (NotImplementedException x)
           {
               if (Debug)
               {
                   Console.WriteLine("GetAllMetadata: " + x.Message);
               }
           }
       }

       public void GetAll(entityType type, int limit)
       {
            
           var url = string.Empty;
           url = ClarizenSession.AuthenticatedServerLocation + ClarizenSession.DataQuery;
           try
           {
               switch (type)
               {
                   case entityType.Task:

                       data.SetQuery(string.Format("SELECT Name, Work FROM Task WHERE StartDate>2015-01-01 LIMIT {0}",limit));
                       data.Query.Select("Name,Work");
                       GetResponse(url);
                       break;
                   default:
                       throw new NotImplementedException("entityType " + type + " currently is in development");
               }
           }
           catch(NotImplementedException x)
           {
               if(Debug) { 
                   Console.WriteLine("GetAll: " + x.Message); 
               }
           }

       }


        /// <summary>
        /// General routine that will perform the relevant HTTP GET.
        /// </summary>
        /// <param name="url"></param>
        public void Get(string url)
        {
            var response = string.Empty;
            using (ClarizenWebClient = new WebClient())
            {
                try
                {
                    Console.WriteLine("Session ID Set in Global-2: " + ClarizenSession.SessionId);
                    ClarizenWebClient.Headers[HttpRequestHeader.Authorization] = string.Format("Session {0}", ClarizenSession.SessionId);
                    ClarizenWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";

                    var responseByte = ClarizenWebClient.DownloadData(url);
                    response = Encoding.UTF8.GetString(responseByte);

                    if (Debug)
                    {
                        Console.WriteLine("Get: " + response);
                    }

                }
                catch (WebException x)
                {
                    if (Debug)
                    {
                        Console.WriteLine("Issue in Get Method " + x.Status);
                    }
                }
            }
        }


        /// <summary>
        /// Very raw implementation
        /// </summary>
        /// <param name="url"></param>
        /// <param name="type"></param>
        public void Get(string url,entityType type)
        {
            var response = string.Empty;

            using (ClarizenWebClient = new WebClient())
            {
                try
                {
                    Console.WriteLine("Session ID Set in Global-2: " + ClarizenSession.SessionId);
                    ClarizenWebClient.Headers[HttpRequestHeader.Authorization] = string.Format("Session {0}", ClarizenSession.SessionId);
                    ClarizenWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";

                    var responseByte = ClarizenWebClient.DownloadData(url);
                    response = Encoding.UTF8.GetString(responseByte);
                    var responseJson = JsonConvert.DeserializeObject<DescribeEntity>(response);

                    var JsonObject = new JObject();
                    foreach(var ed in responseJson.EntityDescriptions)
                    {
                              foreach(var field in ed.Fields)
                              {
                                  switch (field.Type)
                                  {
                                      case "Boolean" :
                                          JsonObject.Add(field.Name, true);
                                          break;

                                      case "String":
                                          JsonObject.Add(field.Name, "example string");
                                          break;

                                      case "Integer":
                                          JsonObject.Add(field.Name, 1);
                                          break;

                                      case "Long":
                                          long l = 4294967296;
                                          JsonObject.Add(field.Name, l);
                                          break;

                                      case "Double":
                                          double d = 3D;
                                          JsonObject.Add(field.Name, d);
                                          break;

                                      //TODO: Need to find away of adding Date to the JSON-To-POCO Creator.
                                      case "Date":
                                      case "DateTime":
                                          DateTime dateTime = new DateTime(2015, 2, 15, 0, 0, 0, DateTimeKind.Utc);
                                          JsonObject.Add(field.Name, dateTime);
                                          break;

                                      case "Entity":
                                          JsonObject.Add(field.Name, "id");
                                          break;
     
                                      case "Duration":
                                          JObject duration = new JObject(new JProperty("unit","Days"),
                                                                        new JProperty("value",1.0));
                                          JsonObject.Add(field.Name, duration);
                                          break;

                                      case "Money":
                                          JObject money = new JObject(new JProperty("currency", "GDP"),
                                                                  new JProperty("value", 1000.0));
                                          JsonObject.Add(field.Name, money);
                                          break;

                                      case "MultiPickList":
                                          JsonObject.Add(field.Name, "todo");
                                          break;

                                      case "Binary":
                                          JsonObject.Add(field.Name, "todo");
                                          break;

                                      default:
                                          break;
                                  }
                              }
                    }
                    var JsonObjectCollection = new JObject();
                    switch (type)
                    {
                        case entityType.Task:
                            JsonObjectCollection.Add("Task", JsonObject);
                           break;

                        default:
                           break;

                    }

                    if (Debug)
                    {
                        Console.WriteLine("Get-2: " + response);
                    }

                }
                catch (WebException x)
                {
                    if (Debug)
                    {
                        Console.WriteLine("Issue in Get-2 Method " + x.Status);
                    }
                }
            }

        }


        /// <summary>
        /// Send a JSON parameter list with the GET Request and await the response
        /// </summary>
        /// <param name="url"></param>
        public void GetResponse(string url)
        {
            string requestJson = JsonConvert.SerializeObject(data.Query);
            string responseJson = string.Empty;
              using (ClarizenWebClient = new WebClient())
              {
                    try
                    {
                        ClarizenWebClient.Headers[HttpRequestHeader.Authorization] = string.Format("Session {0}", ClarizenSession.SessionId);
                        ClarizenWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                        ClarizenWebClient.Headers[HttpRequestHeader.Accept] = "application/json";

                        var responseByte = ClarizenWebClient.UploadData(url, Encoding.UTF8.GetBytes(requestJson));
                        responseJson = Encoding.UTF8.GetString(responseByte);
                        List<string> errors = new List<string>();
                        //data.Response = JsonConvert.DeserializeObject<TaskResponse>(responseJson);
                        data.Response = JsonConvert.DeserializeObject<TaskResponse>(responseJson,
                            new JsonSerializerSettings
                            {
                                Error = delegate(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs args)
                                {
                                    errors.Add(args.ErrorContext.Error.Message);
                                    args.ErrorContext.Handled = true;
                                }
                            });

                        if (Debug)
                        {
                            Console.WriteLine("GetResponse: " + responseJson);
                        }
                    }
                    catch (WebException x)
                    {
                        if (Debug)
                        {
                            Console.WriteLine("Issue in GetResponse Method " + x.Status);
                        }
                    }
              }

        }

        /// <summary>
        /// Excecutes the dynamically created Query.
        /// </summary>
        public void ExecuteQuery()
        {
            var url = string.Empty;
            url = ClarizenSession.AuthenticatedServerLocation + ClarizenSession.DataQuery;
            data.SetQuery();
            if (!data.Query.IsQueryBuilt)
                return;

            string requestJson = JsonConvert.SerializeObject(data.Query);
            string responseJson = string.Empty;
            using (ClarizenWebClient = new WebClient())
            {
                try
                {
                    ClarizenWebClient.Headers[HttpRequestHeader.Authorization] = string.Format("Session {0}", ClarizenSession.SessionId);
                    ClarizenWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    ClarizenWebClient.Headers[HttpRequestHeader.Accept] = "application/json";

                    var responseByte = ClarizenWebClient.UploadData(url, Encoding.UTF8.GetBytes(requestJson));
                    responseJson = Encoding.UTF8.GetString(responseByte);
                    List<string> errors = new List<string>();
                    string serializedJson = string.Empty;

                    if (Regex.IsMatch(responseJson, "/Organization"))
                    {
                        data.Response = JsonConvert.DeserializeObject<OrganizationResponse>(responseJson);
                        serializedJson = JsonConvert.SerializeObject(data.Response,
                                                        Formatting.Indented,
                                                        new JsonSerializerSettings
                                                        {
                                                            NullValueHandling = NullValueHandling.Ignore,
                                                            DefaultValueHandling = DefaultValueHandling.Ignore
                                                        });

       
                        OrganizationResponse org = new OrganizationResponse();
                        org = (OrganizationResponse)data.Response;
                        dataInMemory.Add("Organization", org);
                        
                        CustomApplications.Add("Trello",new ClarizenTrello(org.Organisation[0].CTrelloAPIKey,true));
  
                    }

                    if (Regex.IsMatch(responseJson, "/Task"))
                    {
                        data.Response = JsonConvert.DeserializeObject<TaskResponse>(responseJson);
                        serializedJson = JsonConvert.SerializeObject(data.Response,
                                                        Formatting.Indented,
                                                        new JsonSerializerSettings
                                                        {
                                                            NullValueHandling = NullValueHandling.Ignore,
                                                            DefaultValueHandling = DefaultValueHandling.Ignore
                                                        });

                        TaskResponse task = new TaskResponse();
                        task = (TaskResponse)data.Response;
                        dataInMemory.Add("Task", task);

                    }
                                   
                    /*data.Response = JsonConvert.DeserializeObject<TaskResponse>(responseJson,
                        new JsonSerializerSettings
                        {
                            Error = delegate(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs args)
                            {
                                errors.Add(args.ErrorContext.Error.Message);
                                args.ErrorContext.Handled = true;
                            }
                        }); */
                    if (Debug)
                    {
                        Console.WriteLine("ExcecuteQuery " + responseJson);
                    }
                }
                catch (WebException x)
                {
                    Console.WriteLine("Issue in ExecuteQuery Method " + x.Status);
                }
            }

        }


        /// <summary>
        /// Returns the ID for any Custom Applications installed on the sites implementation.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetCustomApplication (string key)
        {
            IClarizenCustomApplication ca = null;
            if(CustomApplications.TryGetValue(key,out ca))
            {
                 if(ca.GetType() == typeof(ClarizenTrello))
                 {
                    dynamic d = ca;
                    return d.TrelloAPIKey;
                 }
            }

            return null;
        }

 
    }




}
