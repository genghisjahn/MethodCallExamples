using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Net;
//Build this Class From Scartch
//Remove you added System.Web.Extensions

namespace LibraryDemo
{
    public class RemoteSSClient
    {
        public int AddThis(int num1, int num2)
        {
            int result = 0;
            string url = string.Format(@"http://servicestackexample.azurewebsites.net/api/addnums/{0}/{1}?format=json", num1, num2);
            using (var client = new WebClient())
            {
                var json = client.DownloadString(url);
                var serializer = new JavaScriptSerializer();
                Dictionary<string, object> summodel = serializer.Deserialize<Dictionary<string, object>>(json);
                result = (int)summodel.FirstOrDefault().Value;
            }
            return result;
        }
    }
}
