using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bradaz.Clarizen.API.Custom
{
    public class ClarizenTrello : IClarizenCustomApplication  
    {
        private string trelloAPIKey;
        internal bool isApplicationInstalled = false;
        public string TrelloAPIKey
        {
            get
            {
                return trelloAPIKey;
            }

        }

        /// <summary>
        /// Validate that the application is installed.
        /// </summary>
        public bool IsApplicationInstalled
        {
            get
            {
                return isApplicationInstalled;
            }
            internal set
            {
                isApplicationInstalled = value;
            }
        }

        /// <summary>
        /// Default contructor that includes parameter for the Trello Key.
        /// </summary>
        /// <param name="key"></param>
        public ClarizenTrello (string key)
        {
            trelloAPIKey = key;
        }

        /// <summary>
        ///  Constructor which includes the isInstalledFlag.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="isInstalled"></param>
        public ClarizenTrello(string key, bool isInstalled)
        {
            trelloAPIKey = key;
            isApplicationInstalled = isInstalled;
        }
    }
}
