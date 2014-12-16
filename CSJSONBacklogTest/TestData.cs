
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace CSJSONBacklogTest
{
    public class TestData
    {
        public string SpaceName { get; set; }
        public string APIKey { get; set; }

        public string IssueIdOrKey { get; set; }
        
        public int ProjectId { get; set; }
        public string ProjectIdOrKey { get; set; }
        public IEnumerable<int> ProjectIds { get; set; }


        /// <summary>
        /// Return new TestData.
        /// </summary>
        public static TestData CreateNew(string filename, string encodingName = "UTF-8")
        {
            if (string.IsNullOrWhiteSpace(filename)) { throw new ArgumentNullException(@"filename"); }
            
            string json;
            using (var sr = new StreamReader(filename, Encoding.GetEncoding(encodingName)))
            {
                json = sr.ReadToEnd();
                sr.Close();
            }
            if (string.IsNullOrWhiteSpace(json)) { throw new Exception(@"file is empty."); }

            return JsonConvert.DeserializeObject<TestData>(json);
        }
    }
}
