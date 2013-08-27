using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebSoap
{
    /// <summary>
    /// Summary description for RemoteLibrary
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RemoteLibrary : System.Web.Services.WebService
    {

        [WebMethod]
        public int AddThis(int a, int b)
        {
            return a + b;
        }
    }
}
