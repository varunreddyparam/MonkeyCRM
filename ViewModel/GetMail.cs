using System;
using System.Collections.Generic;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using MailApplication;

namespace MonkeyCRM.ViewModel
{
    public class GetMail
    {
        public ConnectGmail gmailConnection = new ConnectGmail();
        public RetrieveMessages retrieveMessages = new RetrieveMessages();

        private string date;
        private string subject;
        private string from;
        private string body;
        private string messageid;
        private string userid = "me";
        private string historyid;
        private string threadid;

        public List<MailMessage> Main()
        {
            try
            {
                var gmailService = gmailConnection.CreateGmailAPIservice();
                if (gmailService != null)
                {
                    string query = "label:Jobs";
                    //"label:jobs after:2019/12/18 before:2019/12/19 is:unread";
                    //
                    var messages = retrieveMessages.GetGmailMessageList(gmailService, this.userid, query);

                    if (messages != null && messages.Count >= 0)
                    {
                        Console.WriteLine("there are {0} emails!", messages.Count);
                        return this.GetEmailMessageData(gmailService, this.userid, messages);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public List<MailMessage> GetEmailMessageData(GmailService gmailService, string UserId, List<Message> messages)
        {
            List<MailMessage> mailMessagesList = new List<MailMessage>();
            try
            {
                foreach (var message in messages)
                {
                    this.messageid = message.Id;
                    this.historyid = message.HistoryId.ToString();
                    this.threadid = message.ThreadId;
                    var messageInfoResponse = retrieveMessages.GetMessage(gmailService, UserId, message.Id);
                    if (messageInfoResponse != null)
                    {
                        //loop through the headers and get the fields we need...
                        ExtractMessageData(messageInfoResponse);
                    }
                    mailMessagesList.Add(new MailMessage(this.date, this.from, this.subject, this.body, this.messageid, this.historyid, this.threadid));
                    Console.WriteLine("{0}  --  {1}", this.subject, this.date);
                }
                return mailMessagesList;
            }
            catch (Exception ex)
            {

            }
            return null;
        }


        public void ExtractMessageData(Message messageInfoResponse)
        {
            try
            {

                foreach (var mParts in messageInfoResponse.Payload.Headers)
                {
                    switch (mParts.Name)
                    {
                        case "Date":
                            this.date = mParts.Value;
                            break;
                        case "From":
                            this.from = mParts.Value;
                            break;
                        case "Subject":
                            this.subject = mParts.Value;
                            break;
                        default:
                            break;
                    }

                    if (this.date != "" && this.from != "")
                    {
                        if (messageInfoResponse.Payload.Parts == null && messageInfoResponse.Payload.Body != null)
                            this.body = retrieveMessages.DecodeBase64String(messageInfoResponse.Payload.Body.Data);
                        else
                            this.body = retrieveMessages.GetNestedBodyParts(messageInfoResponse.Payload.Parts, "");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
