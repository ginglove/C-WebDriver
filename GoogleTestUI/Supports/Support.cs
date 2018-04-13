using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GoogleTestUI.Supports
{
    class Support
    {
        public void LoadJson(string path)
        {
            StreamReader rd = File.OpenText(path);
            string json = rd.ReadToEnd();
            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            while (reader.Read())
            {
                if (reader.Value != null)
                {
                    Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
                }
                else
                {
                    Console.WriteLine("Token: {0}", reader.TokenType);
                }
            }
            Console.ReadLine();
        }
        public static T ParseJsonObject<T>(string json) where T : class, new()
        {
            JObject jobject = JObject.Parse(json);
            return JsonConvert.DeserializeObject<T>(jobject.ToString());
        }
        public void GetJsonData(string keyname,string path)
        {
            StreamReader rd = File.OpenText(path);
            string json = rd.ReadToEnd();
            //JsonTextReader reader = new JsonTextReader(new StringReader(json));
            JArray parsedArray = JArray.Parse(json);
            foreach (JObject parsedObject in parsedArray.Children<JObject>())
            {
                foreach (JProperty parsedProperty in parsedObject.Properties())
                {
                    string propertyName = parsedProperty.Name;
                    if (propertyName.Equals(keyname))
                    {
                        string propertyValue = (string)parsedProperty.Value;
                        Console.WriteLine("Name: {0}, Value: {1}", propertyName, propertyValue);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
