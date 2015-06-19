/* See the file "LICENSE" for the full license governing this code. */

using System.Collections.Generic;
using System.Linq;

namespace CSJSONBacklog.Model
{
    public class ErrorMessages
    {
        public ErrorMessages() { errors = new List<Error>();}

        public List<Error> errors { get; set; }

        public bool HasError
        {
            get { return errors != null && errors.Any(); }
        }

        public override string ToString()
        {
            return errors.Aggregate("", (current, error) => current + " " + error);
        }
    }

    public class Error
    {
        public string message { get; set; }
        public int code { get; set; }
        public string moreInfo { get; set; }

        public override string ToString()
        {
            return string.Format("Error: code: {0}, message: {1}, moreInfo: {2}", code, message, moreInfo);
        }
    }
}
