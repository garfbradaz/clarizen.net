using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Bradaz.Clarizen.Helpers;
using System.Runtime.InteropServices;


namespace Bradaz.Clarizen.API
{
    /// <summary>
    /// Authenticate with Clarizen Servers Wrapper.
    /// </summary>
    internal class Authenticate
    {
        #region getServerDefinition
        private WebClient client;
        private ClarizenCredentials credentials;


        #region Response
        private AuthenticateResponse response;
        private LoginResponse loginResponse;
        #endregion
        //todo: add login options.
        #endregion
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>  
        public Authenticate()
        {
            this.credentials = new ClarizenCredentials(ClarizenSession.UserName, ClarizenSession.Password);
            string requestJson = JsonConvert.SerializeObject(credentials);
            string responseJson = string.Empty;

            using (client = new WebClient())
            {
                try
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    client.Headers[HttpRequestHeader.Accept] = "application/json";

                    var responseByte = client.UploadData(ClarizenSession.BaseAddress + ClarizenSession.Authentication + ClarizenSession.GetServerDefinition, Encoding.UTF8.GetBytes(requestJson));
                    responseJson = Encoding.UTF8.GetString(responseByte);
                    response = JsonConvert.DeserializeObject<AuthenticateResponse>(responseJson);

                    Console.WriteLine(responseJson);
                    Console.WriteLine("serverlocation: " + response.ServerLocation + " applocation: " + response.AppLocation);

                    ///Now we login now we have the server.
                    requestJson = string.Empty;
                    responseJson = string.Empty;

                    //TODO add the Application Name as a setting with ClarizenSession in Global.
                     Login login = new Login(credentials.Username, credentials.Password,
                         new loginOptions ("ClarizenAPIWrapper"));
                    requestJson = JsonConvert.SerializeObject(login);
                    var loginResponseByte = client.UploadData(response.ServerLocation + ClarizenSession.Login,Encoding.UTF8.GetBytes(requestJson));
                    responseJson = Encoding.UTF8.GetString(loginResponseByte);
                    loginResponse = JsonConvert.DeserializeObject<LoginResponse>(responseJson);
                    Console.WriteLine(responseJson);      
                    Console.WriteLine("LicenceType: " + loginResponse.LicenceType);

                    ClarizenSession.SessionId = loginResponse.SessionId;
                    ClarizenSession.AuthenticatedServerLocation = response.ServerLocation;
                    ClarizenSession.HasAuthenticated = true;
                    Console.WriteLine("Session ID Set in Global: " + ClarizenSession.SessionId);


                }
                catch (WebException x)
                {
                    Console.WriteLine("Status: " + x.Status);
                }
            }

        }
    }

    /// <summary>
    /// Response back from Clarizen with the server to use.
    /// </summary>
    internal class AuthenticateResponse
    {
        private string serverLocation;
        public string ServerLocation
        {
            get { return serverLocation; }
            private set { }
        }

        private string appLocation;
        public string AppLocation
        {
            get { return appLocation; }
            private set { }
        }


        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="serverLocation"></param>
        /// <param name="appLocation"></param>
        public AuthenticateResponse(string serverLocation, string appLocation)
        {
            this.serverLocation = serverLocation;
            this.appLocation = appLocation;
        }
    }


    /// <summary>
    /// Login Options for Logging in.
    /// </summary>
    internal class loginOptions
    {

        private string partnerId;
        public string PartnerId
        {
            get { return partnerId; }
            private set { }
        }

        private string applicationId;
        public string ApplicationId
        {
            get { return applicationId; }
            private set { }
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public loginOptions()
        { }
        /// <summary>
        /// Comstructor to include application ID (Partner ID is optional).
        /// </summary>
        /// <param name="applicationId"></param>
        public loginOptions(string applicationId)
        {
            this.partnerId = null;
            this.applicationId = applicationId;
        }

        /// <summary>
        /// Full constructor including optional partnerId.
        /// </summary>
        /// <param name="partnerId"></param>
        /// <param name="applicationId"></param>
        public loginOptions(string partnerId, string applicationId)
        {
            this.partnerId = partnerId;
            this.applicationId = applicationId;
        }

    }


    /// <summary>
    /// Login request details once we have authenicated the server we need to contact.
    /// </summary>
    internal class Login : ClarizenCredentials
    {
        private loginOptions loginOptions;
        public loginOptions LoginOptions
        {
            get { return loginOptions; }
            private set { }
        }
        public Login(string userName, string passWord, loginOptions loginOptions)
            : base(userName, passWord)
        {
            this.loginOptions = loginOptions;
        }


    }

    /// <summary>
    /// Response given for logging in.
    /// </summary>
    internal class LoginResponse
    {
        private string sessionId;    
        [JsonProperty("sessionId")]
        public string SessionId
        {
            get { return sessionId; }
            set { sessionId = value; }
        }

        private string userId;
        [JsonProperty("userId")]
        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        private string organizationId;
        [JsonProperty("organizationId")]
        public string OrganizationId
        {
            get { return organizationId; }
            set { organizationId = value; }
        }

        private licenceType licenceType;
        [JsonProperty("licenceType")]
        public licenceType LicenceType
        {
            get { return licenceType; }
            set { licenceType = value; }
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public LoginResponse()
        { }

    }

    /// <summary>
    /// Clarizen Authenticaion Details.
    /// </summary>
    internal class ClarizenCredentials
    {
        private string userName;
        public  string Username
        {
            get { return userName; }
            private set { }
        }

        private string password;
        public string Password
        {
            get { return password; }
            private set { }
        }


        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public ClarizenCredentials(string userName, string password)
        {
            this.userName = userName;
            this.password = password;

        }
    }
}

