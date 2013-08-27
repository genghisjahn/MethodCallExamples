using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.Common;
using ServiceStack.WebHost.Endpoints;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using ServiceStackExample;
namespace ServiceStackExample.processor
{
    public class AddThisProcessor:Service
    {
        public responses.AddNumsResponse Get(requests.AdditionRequest request)
        {
            responses.AddNumsResponse result = new responses.AddNumsResponse();
            result.Sum = request.num1 + request.num2;
            result.CreatedOn = DateTime.UtcNow;
            return result;
        }
    }
}