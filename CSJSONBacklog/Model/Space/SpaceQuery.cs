using CSJSONBacklog.Model.Issues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSJSONBacklog.Model.Space
{
    public class SpaceQuery : AbstractParameter
    {
        public Order Order { get; set; }
        public int Offset { get; set; }
        public int Count { get; set; }
        
        public string GetParametersForAPI()
        {
            var parameters = string.Format("&offset={0}&count={1}&order={2}",
                                    Offset,
                                    Count,
                                    Order);

            return parameters;
        }
    }
}
