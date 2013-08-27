using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.ServiceHost;

namespace ServiceStackExample.requests
{
    [Route("/addnums/{num1}/{num2}","GET")]
    public class AdditionRequest
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
    }
}