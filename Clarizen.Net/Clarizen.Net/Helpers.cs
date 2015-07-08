using Newtonsoft.Json.Linq;
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

    public static class JsonExtensions
    {

        public static void FindTokensAndRemove(this JToken containerToken, string name)
        {
           
            if (containerToken.Type == JTokenType.Object)
            {
               
                foreach (JProperty child in containerToken.Children<JProperty>().ToList())
                {
                    if (child.Name == name || child.Name.Contains(name))
                    {
                        child.Remove();
                    }
                    FindTokensAndRemove(child.Value, name);
                }
            }
            else if (containerToken.Type == JTokenType.Array)
            {
                foreach (JToken child in containerToken.Children())
                {
                    FindTokensAndRemove(child, name);
                }
            }
        }

        /// <summary>
        /// Recursive function to find matches for tokens.
        /// This code has come from a Stackoverflow answer:
        /// http://stackoverflow.com/questions/19645501/searching-for-a-specific-jtoken-by-name-in-a-jobject-hierarchy
        /// </summary>
        /// <param name="containerToken"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<JToken> FindTokens(this JToken containerToken, string name)
        {
            List<JToken> matches = new List<JToken>();
            FindTokens(containerToken, name, matches);
            return matches;
        }

        private static void FindTokens(JToken containerToken, string name, List<JToken> matches)
        {
            if (containerToken.Type == JTokenType.Object)
            {
                foreach (JProperty child in containerToken.Children<JProperty>())
                {
                    if (child.Name == name || child.Name.Contains(name))
                    {
                        matches.Add(child.Value);
                    }
                    FindTokens(child.Value, name, matches);
                }
            }
            else if (containerToken.Type == JTokenType.Array)
            {
                foreach (JToken child in containerToken.Children())
                {
                    FindTokens(child, name, matches);
                }
            }
        }
    }
}

