/* See the file "LICENSE" for the full license governing this code. */

using System;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Text;
using CSJSONBacklog.Model;

namespace CSJSONBacklog.Communicator
{
    public abstract class AbstractCommunicator : AbstractParameter, ICommunicator
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
            string result = string.Empty;
            Stream stream = null;

            try
            {
                var httpWReq = (HttpWebRequest)WebRequest.Create(uri);
                httpWReq.Method = "GET";
                httpWReq.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
                httpWReq.KeepAlive = true;

                var httpWResp = (HttpWebResponse)httpWReq.GetResponse();
                stream = httpWResp.GetResponseStream();
                if (stream != null)
                {
                    using (var sr = new StreamReader(stream, Encoding.UTF8))
                    {
                        stream = null;
                        result = sr.ReadToEnd();
                    }
                }

                httpWResp.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                if (stream != null) { stream.Dispose(); }
            }

            return result;
        }
    }
}
