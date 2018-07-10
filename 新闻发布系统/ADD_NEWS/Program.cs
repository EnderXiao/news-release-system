using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DAL;

namespace ADD_NEWS
{
    class Program
    {
        static void Main(string[] args)
        {
            Readjson();
            Console.Read();
        }

        public static void Readjson()
        {
            string jsonfile = "G:\\Study\\python\\test\\news\\yuleNews.json";

            using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JToken o = JToken.ReadFrom(reader);
                    foreach (JObject e in o)
                    {
                        string title = e["title"].ToString();
                        string time = e["time"].ToString();
                        string content = e["content"].ToString();
                        //Console.WriteLine(title + "\n");
                        try
                        {
                            bool b = Dal.Add_news(title, time, content);
                            Console.WriteLine(b);
                        }
                        catch (Exception i)
                        {
                            throw i;
                        }
                    }
                }
            }

        }
    }
}
