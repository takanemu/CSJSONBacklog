/* See the file "LICENSE" for the full license governing this code. */

using System;
using System.IO;
using System.Net;
using System.Text;

namespace CSJSONBacklog.Communicator
{
    public abstract class AbstractCommunicator : ICommunicator
    {
        public string Spacename { get; private set; }
        public string ApiKey { get; private set; }

        protected AbstractCommunicator(string spacename, string apiKey)
        {
            Spacename = spacename;
            ApiKey = apiKey;
        }

        public string GetJson(string uri)
        {
            var result = string.Empty;

            try
            {
                WebRequest request = WebRequest.Create(uri);
                WebResponse ws = request.GetResponse();

                Stream stream = ws.GetResponseStream();
                if (stream == null) { return string.Empty; }
                
                using (var s = new StreamReader(stream, Encoding.UTF8))
                {
                    result = s.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            return result;
        }
    }
}
