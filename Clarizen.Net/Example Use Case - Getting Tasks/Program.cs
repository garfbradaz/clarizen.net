using Bradaz.Clarizen.API;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Example_Use_Case___Getting_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Replace 'username' and 'password' with your credentials
            RestClient client = new RestClient("garfbradaz","Poohead26@");


            bool runCZQL = false;
            bool Task = true;
            bool Organisation = true;

            if (runCZQL == true)
            {

                client.Debug = true;
                if (Task)
                {    /// Select query takes in the field names from the table(s) specified in From.
                    client.Data.Query.Select("Name,Work,CreatedOn,ActualCost,RemainingEffort") 
                                     .From("Task")
                                     .Where("StartDate > 2015-06-01");
                    client.ExecuteQuery();
                }
                if (Organisation)
                {
                    client.Data.Query.Select("Name,C_TrelloAPIKey") 
                                    .From("Organization")
                                    .Limit(1, 0);
                    client.ExecuteQuery();
                }

            }
            else
            {
                client.GetAllMetadataDescribeEntitiesAndGetAllFields(entityType.Task);
               // Debug.WriteLine(client.ConvertedMetadata);
                Debug.WriteLine(client.ConvertedMetadataWithoutCustomFields);
                /*Debug.WriteLine(client.ListEntities);
                foreach(string s in client.ListEntities)
                {
                    Console.WriteLine(s);  
                }    */
            }



            Console.ReadLine();
        }
    }
}
