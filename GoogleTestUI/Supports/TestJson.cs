using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTestUI.Supports
{
    class TestJson:Support
    {
        static void Main(string[] args)
        {
            Support tr = new Support();
            String path= @"C:\Users\gianglt\Desktop\ExampleTest.json";
            string a = "AuthenticateCmdlets";
            tr.GetJsonData(a, path);
        }
        
    }
}
