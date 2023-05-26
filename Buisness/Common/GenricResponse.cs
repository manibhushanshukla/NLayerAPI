using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Common
{
    public  class GenricResponse
    {
        public HttpStatusCode Response { get; set; }
        public bool Status { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
    }
}
