using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace MonkeyCRM.ViewModel
{
    public class ConnectGmail
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/gmail-dotnet-quickstart.json
        private string[] Scopes = { GmailService.Scope.MailGoogleCom };
        private string ApplicationName = "Gmail API CRM";
        /// <summary>
        /// getUserCredentials for Firstime
        /// </summary>
        /// <returns>UserCredential</returns>
        public UserCredential userCredential()
        {
            UserCredential credential;
            using (var stream =
               new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/gmail-dotnet-quickstart2.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            return credential;
        }

        /// <summary>
        /// Return Gmail Service
        /// </summary>
        /// <returns>GmailService</returns>
        public GmailService CreateGmailAPIservice()
        {
            return new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = userCredential(),
                ApplicationName = ApplicationName,
            });
        }
    }
}
