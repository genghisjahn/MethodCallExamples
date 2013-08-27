using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemo
{
    class LibDemo
    {
        
        static void Main(string[] args)
        {
            RunTest();
        }
        static void RunTest()
        {
            SoapExample.LocalLibrary locallib = new SoapExample.LocalLibrary();
            remoteSoap.RemoteLibrarySoapClient remoteclient = new remoteSoap.RemoteLibrarySoapClient();
            var ssCall = new RemoteSSClient();

            Console.Clear(); 

            RunTest(locallib, "Local Assembly", 100, 100, ConsoleColor.Green);
            RunTest(remoteclient, @"SOAP/XML", 100, 100, ConsoleColor.Red);
            RunTest(ssCall, "Service Stack", 100, 100, ConsoleColor.Cyan);

            var key= Console.ReadKey();
            if (key.Key !=ConsoleKey.Q)
            {
                RunTest();
            }
            
            
        }
        private static string GetDiff(DateTime d1, DateTime d2)
        {
            TimeSpan ts = d2 - d1;
            return ((int)ts.Ticks).ToString("N0");
        }
        private static void RunTest(dynamic service,string name, int num1, int num2, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            DateTime start = DateTime.UtcNow;
            Console.WriteLine("{0}: {1} + {2} = ",name, num1, num2);
            var local = service.AddThis(num1, num2);
            Console.WriteLine("{0} Answer: {1}",name, local);
            DateTime end = DateTime.UtcNow;
            Console.WriteLine("{0} Ticks: {1}",name, GetDiff(start, end));
            Console.WriteLine("-----");
        }
    }
}
