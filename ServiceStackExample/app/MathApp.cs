using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.Common;
using ServiceStack.WebHost.Endpoints;
using ServiceStack.ServiceHost;
using Funq;
using ServiceStack.Text;

namespace ServiceStackExample.app
{
    public class MathApp : AppHostBase
    {
        public MathApp() : base("MathApp for Service Stack", typeof(MathApp).Assembly) { }

        public override void Configure(Funq.Container container)
        {
            
        }
    }
}